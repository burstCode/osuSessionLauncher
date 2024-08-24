using System.Text.Json;

namespace Configurator
{
    public class JsonController
    {
        private readonly string _filePath;

        public JsonController(string filePath)
        {
            _filePath = filePath;
        }

        // Метод для сохранения данных о путях приложений в JSON файл
        public bool Save(DataModel data)
        {
            try
            {
                // Опции для форматирования JSON
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // Для красивого форматирования JSON
                };

                // Сериализация объекта в строку JSON
                string jsonData = JsonSerializer.Serialize(data, options);

                // Создаем папку для конфига, если ее нет
                string folderPath = Path.GetDirectoryName(_filePath);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                File.WriteAllText(_filePath, jsonData);

                MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        // Метод для загрузки данных из JSON файла
        public DataModel Load()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    throw new FileNotFoundException("файл конфигурации не найден.\nСначала настройте его утилитой Configure.exe");
                }

                string jsonData = File.ReadAllText(_filePath);

                DataModel data = JsonSerializer.Deserialize<DataModel>(jsonData);

                MessageBox.Show("Данные успешно загружены!", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

}