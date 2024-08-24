using System.Diagnostics;

using Configurator;

namespace Launcher
{

    static class Program
    {
        // const string CONFIG_FILE_PATH = "data/config.json";
        const string CONFIG_FILE_PATH = @"C:\Users\mikex\source\repos\osuSessionLauncher\Configure\bin\Debug\net8.0-windows\data\config.json";

        static void Main(string[] args)
        {
            // Считываем данные из конфига
            JsonController jsonController = new JsonController(CONFIG_FILE_PATH);

            DataModel data = jsonController.Load();

            if (data == null)
            {
                return;
            }

            if (!isPathsAccessable(data))
            {
                return;
            }


            // Запускаем все программы
            string[] programNames = splitPaths(data);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Запуск процесса: "); Console.ResetColor(); Console.Write(programNames[0]);
            Process.Start(data.PathToOsu);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nЗапуск процесса: "); Console.ResetColor(); Console.Write(programNames[1]);
            ProcessStartInfo OBSStartInfo = new ProcessStartInfo
            {
                FileName = data.PathToOBS,
                WorkingDirectory = Path.GetDirectoryName(data.PathToOBS),
                UseShellExecute = false,
                EnvironmentVariables = { ["PATH"] = Environment.GetEnvironmentVariable("PATH") }
            };
            Process.Start(OBSStartInfo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nЗапуск процесса: "); Console.ResetColor(); Console.Write(programNames[2]);
            Process.Start(data.PathToSC);

            Console.ResetColor();
        }

        public static bool isPathsAccessable(DataModel data)
        {
            // Список путей, где не найдены файлы
            List<string> missingFiles = new List<string>();

            // Проверка существования каждого файла
            if (!File.Exists(data.PathToOsu))
            {
                missingFiles.Add(data.PathToOsu);
            }
            if (!File.Exists(data.PathToOBS))
            {
                missingFiles.Add(data.PathToOBS);
            }
            if (!File.Exists(data.PathToSC))
            {
                missingFiles.Add(data.PathToSC);
            }
            // Если есть пути, где файлы не найдены
            if (missingFiles.Count > 0)
            {
                string message = "Не удалось найти следующие файлы:\n" + string.Join("\n", missingFiles);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();

                Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
                Console.ReadKey();

                return false;
            }

            return true;
        }
        
        public static string[] splitPaths(DataModel data)
        {
            string[] programNames = new string[3];

            string[] OsuPathParts = data.PathToOsu.Split('\\');
            string[] OBSPathParts = data.PathToOBS.Split('\\');
            string[] SCPathParts = data.PathToSC.Split('\\');

            programNames[0] = OsuPathParts[OsuPathParts.Length - 1];
            programNames[1] = OBSPathParts[OBSPathParts.Length - 1];
            programNames[2] = SCPathParts[SCPathParts.Length - 1];

            return programNames;
        }
    }
}
