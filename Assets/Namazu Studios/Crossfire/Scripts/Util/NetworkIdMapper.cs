
namespace Elements.Crossfire
{

    public class NetworkIdMapper
    {
        public static ulong DeterministicClientId(string profileId, string matchId)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var input = System.Text.Encoding.UTF8.GetBytes(profileId + matchId);
            var hash = sha.ComputeHash(input);

            // Take first 8 bytes → UInt64
            return System.BitConverter.ToUInt64(hash, 0);
        }
    }
}