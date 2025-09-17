﻿#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Debug = UnityEngine.Debug;
using Newtonsoft.Json;

namespace Elements.Codegen
{
    public class CodegenUtils
    {
        public CodegenConfig Config { get; set; }

        public string UserId { get; set; }
        public string Password { get; set; }

        private string sessionToken;
        private string configPath;

        private const string codegenFilename = "codegen_configuration";

        /// <summary>
        /// Attempts to generate the code in response to the button click
        /// </summary>
        public void GenerateCode(string elementSpecUrl)
        {
            try
            {
                RefreshSession();

                if (sessionToken == null) return;

                CodegenPrecheck();

                DoGenerateCode(Config.GetPath(), elementSpecUrl);

                AssetDatabase.Refresh();
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }


        /// <summary>
        /// Attempts to fetch a session token with the provided user id and password.
        /// A SUPERUSER account is required to generate the code.
        /// </summary>
        public void RefreshSession()
        {
            sessionToken = null;

            var url = Config.urlRoot + "/api/rest/session";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var requestData = "{\"userId\":\"" + UserId + "\",\"password\":\"" + Password + "\"}";
            var requestBytes = Encoding.ASCII.GetBytes(requestData);

            request.Method = WebRequestMethods.Http.Post;
            request.ContentLength = requestBytes.Length;
            request.ContentType = "application/json";

            using Stream dataStream = request.GetRequestStream();
            dataStream.Write(requestBytes, 0, requestBytes.Length);

            using WebResponse response = request.GetResponse();
            var sr = new StreamReader(response.GetResponseStream());
            var responseString = sr.ReadToEnd();
            var responseDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseString);

            if (responseDict.TryGetValue("sessionSecret", out object sessionSecret))
            {
                sessionToken = (string)sessionSecret;
            }
            else
            {
                Debug.LogError("Could not fetch session! Make sure that the server is running and the credentials are correct.");
            }
        }


        /// <summary>
        /// Attempts to generate the code at the given url
        /// </summary>
        public void DoGenerateCode(string generatedCodePath, string applicationName)
        {
            try
            {
                var url = Config.urlRoot + "/api/rest/codegen";
                var filePath = Path.Combine(generatedCodePath, "ElementsCore.zip");

                var elementSpecUrl = applicationName == null ? null : $"{Config.urlRoot}/app/rest/{Config.applicationName}/openapi.json";

                try
                {
                    using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        var request = (HttpWebRequest)WebRequest.Create(url);

                        var requestBody = new Dictionary<string, string>
                        {
                            { "elementSpecUrl", elementSpecUrl },
                            { "language", "csharp" },
                            { "packageName", Config.packageName },
                            { "options", "library=unityWebRequest," +
                                         "optionalEmitDefaultValues=false," +
                                         "nullableReferenceTypes=false," +
                                         "useDateTimeOffset=false," +
                                         "targetFramework=net48," +
                                         "useDateTimeForDate=true," +
                                         "optionalAssemblyInfo=false," +
                                         "optionalProjectFile=false," +
                                         "useStringEnum=true" }
                        };

                        var requestData = JsonConvert.SerializeObject(requestBody);

                        var requestBytes = Encoding.ASCII.GetBytes(requestData);

                        request.Method = WebRequestMethods.Http.Post;
                        request.ContentLength = requestBytes.Length;
                        request.ContentType = "application/json";

                        request.Headers.Add("Elements-SessionSecret", sessionToken);

                        using (Stream dataStream = request.GetRequestStream())
                        {
                            dataStream.Write(requestBytes, 0, requestBytes.Length);
                        }

                        using var response = (HttpWebResponse)request.GetResponse();
                        using var responseStream = response.GetResponseStream();
                        const int BUFFER_SIZE = 16 * 1024;

                        var buffer = new byte[BUFFER_SIZE];
                        int bytesRead;

                        do
                        {
                            bytesRead = responseStream.Read(buffer, 0, BUFFER_SIZE);
                            fileStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead > 0);

                        fileStream.Close();
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }

                ZipFile.ExtractToDirectory(filePath, generatedCodePath, true);
                File.Delete(filePath);

                ApplyFixes(generatedCodePath);
                SetGlobalDefines();
            }
            catch (Exception e)
            {
                Debug.LogError($"Could not run codegen!\n{e.Message}");
            }
        }


        public void CodegenPrecheck()
        {
            CheckConfiguration();

            //Just in case this was deleted from the project after the
            //config was loaded into memory
            CheckDirectory(Path.GetDirectoryName(configPath));

            //Save the config just in case any changes were made
            File.WriteAllText(configPath, Config.ToJson());

            string basePath = Config.GetPath();
            string modelPath = Path.Combine(basePath, "Model");
            string apiPath = Path.Combine(basePath, "Api");

            //Make sure all the directories exist and create them if not
            CheckDirectory(basePath);
            CheckDirectory(modelPath);
            CheckDirectory(apiPath);
        }


        /// <summary>
        /// Checks to see if the configuration is in memory and attempts to load it from disk if not.
        /// </summary>
        /// <returns>If the config is loaded or not</returns>
        public void CheckConfiguration()
        {
            try
            {
                if (Config == null || configPath == null)
                {
                    TryLoadConfig();
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }


        /// <summary>
        /// Attempts to search the project and load the config. If not found, will create a new default config.
        /// </summary>
        public void TryLoadConfig()
        {
            //First, try to find and load the config from anywhere in the project
            try
            {
                string[] assets = AssetDatabase.FindAssets(codegenFilename);
                string configGuid = assets.FirstOrDefault();

                if (!string.IsNullOrEmpty(configGuid))
                {
                    configPath = AssetDatabase.GUIDToAssetPath(configGuid);
                    TextAsset configText = AssetDatabase.LoadAssetAtPath<TextAsset>(configPath);
                    Config = JsonUtility.FromJson<CodegenConfig>(configText.text);
                }

                //If the above failed, then we create a new config file using the defaults
                if (Config == null)
                {
                    assets = AssetDatabase.FindAssets("ElementsCodegenGui");
                    configGuid = assets.FirstOrDefault();
                    Config = new CodegenConfig();
                }

                if (configPath == null)
                {
                    string configPath;

                    //We'll try to place the config file in a folder named "Config"
                    //relative to the location of this script.
                    if (!string.IsNullOrEmpty(configGuid))
                    {
                        string dir = Path.GetDirectoryName(AssetDatabase.GUIDToAssetPath(configGuid));
                        configPath = Path.Combine(dir, "Config");
                    }
                    //If for some reason we can't find the location of this script
                    //(you renamed it, didn't you?), we'll place it at the project root.
                    else
                    {
                        configPath = Application.dataPath;
                    }

                    CheckDirectory(configPath);

                    configPath = Path.Combine(configPath, $"{codegenFilename}.txt");
                    File.WriteAllText(configPath, Config.ToJson());

                    AssetDatabase.Refresh();
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"There was an error loading the config! Generating defaults... \n{e.Message}");
            }
        }


        /// <summary>
        /// Checks to see if a directory exists at the given path and creates it if not
        /// </summary>
        /// <param name="path">The path to check at</param>
        public void CheckDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        /// <summary>
        /// Applies any fixes required to avoid compiler errors with the generated code
        /// </summary>
        public void ApplyFixes(string path)
        {
            RemoveAssemblyDef(path);
            RemoveTestDir(path);
            FixApiClient(path);

            CodeTemplates codeTemplates = new CodeTemplates();

            AddRequestHooks(codeTemplates);
            AddElementsClient(codeTemplates);
        }

        private void RemoveAssemblyDef(string path)
        {
            //Remove unwanted assembly def files (only used for test files)
            var asmdefFiles = Directory.GetFiles(path, "*asmdef*", SearchOption.AllDirectories);
            asmdefFiles.ToList().ForEach(f =>
            {
                File.Delete(f);
            });
        }

        private void RemoveTestDir(string path)
        {
            //Remove generated test directory
            Directory.GetDirectories(path, Config.packageName + ".Test", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f =>
                {
                    Directory.Delete(f, true);
                });
        }

        private void FixApiClient(string path)
        {
            //Fix ApiClient
            string apiClientPath = Directory.GetFiles(path, "ApiClient.cs", SearchOption.AllDirectories).FirstOrDefault();
            string[] fileText = File.ReadAllLines(apiClientPath);

            for (int i = 0; i < fileText.Length; ++i)
            {
                string line = fileText[i];

                if (line.Contains("configuration.Timeout") && !line.Contains("configuration.Timeout.Milliseconds"))
                {
                    fileText[i] = line.Replace("configuration.Timeout", "configuration.Timeout.Milliseconds");
                }
                else if (line.Contains("ApiException"))
                {
                    /**
                     * Removes the following case to prevent exceptions being thrown before the ExceptionFactory is called:
                     else
                    {
                        throw new ApiException((int)request.responseCode, request.error, text);
                    }
                    */
                    fileText[i - 2] = "";
                    fileText[i - 1] = "";
                    fileText[i] = "";
                    fileText[i + 1] = "";
                }
            }

            File.WriteAllLines(apiClientPath, fileText);
        }

        private void AddRequestHooks(CodeTemplates codeTemplates)
        {
            //Add ApiClient request hooks            
            var fileText = codeTemplates.apiClientHookTemplate.Replace("{namespace}", Config.packageName);
            File.WriteAllText(Path.Combine(Application.dataPath, Config.relativeDirectory, "src", Config.packageName, "ApiClient.partial.cs"), fileText);
        }

        private void AddElementsClient(CodeTemplates codeTemplates)
        {
            //Add ElementsClient
            var fileText = codeTemplates.elementsClientTemplate.Replace("{namespace}", Config.packageName);
            File.WriteAllText(Path.Combine(Application.dataPath, Config.relativeDirectory, "ElementsClient.cs"), fileText);
        }

        private void SetGlobalDefines()
        {
            var path = Path.Combine(Application.dataPath, "csc.rsp");
            var customDefines = "-define:ELEMENTS_GENERATED";

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);

                if (!lines.Any(line => line.Contains(customDefines)))
                {
                    var linesList = lines.ToList();
                    linesList.Add(customDefines);

                    File.WriteAllLines(path, linesList.ToArray());
                }
            }
            else
            {
                File.WriteAllText(path, customDefines);
            }
        }
    }
}

#endif