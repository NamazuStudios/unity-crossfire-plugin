
namespace Elements.Crossfire
{
    public class LoggerFactory
    {
        public static Logger GetLogger(string className)
        {
            return new Logger(className);
        }

        public static Logger GetLogger(System.Type type)
        {
            return new Logger(type.Name);
        }
    }    
}