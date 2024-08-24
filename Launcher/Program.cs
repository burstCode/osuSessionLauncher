using Configurator;

namespace Launcher
{

    class Program
    {
        const string CONFIG_FILE_PATH = "data/config.json";

        static void Main(string[] args)
        {
            JsonController jsonController = new JsonController(CONFIG_FILE_PATH);

            DataModel data = jsonController.Load();

            

            
        }
    }
}