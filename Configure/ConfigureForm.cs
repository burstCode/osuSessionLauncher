namespace Configurator
{
    public partial class ConfigureForm : Form
    {
        public ConfigureForm()
        {
            InitializeComponent();

            PathToOsu.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Local\osu!";
            PathToOBS.Text = @"C:\Program Files\obs-studio\bin\64bit";
            // PathToSC.Text = @"";
        }

        private void btnPathToOsu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PathToOsu.Text = folderBrowserDialog.SelectedPath;
            }
        }


        private void btnPathToOBS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Если указан неполный путь до папки с .exe файлом
                string[] pathParts = folderBrowserDialog.SelectedPath.Split('\\');
                if (pathParts[pathParts.Length - 1] == "obs-studio")
                {
                    folderBrowserDialog.SelectedPath += @"\bin\64bit";
                }
                else if (pathParts[pathParts.Length - 1] == "bin")
                {
                    folderBrowserDialog.SelectedPath += @"\64bit";
                }

                PathToOBS.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnPathToSC_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PathToSC.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Пути к файлам
            string osuPath = Path.Combine(PathToOsu.Text, "osu!.exe");
            string obsPath = Path.Combine(PathToOBS.Text, "obs64.exe");
            string scPath = Path.Combine(PathToSC.Text, "StreamCompanion.exe");

            // Список путей, где не найдены файлы
            List<string> missingFiles = new List<string>();

            // Проверка существования каждого файла
            if (!File.Exists(osuPath))
            {
                missingFiles.Add(osuPath);
            }
            if (!File.Exists(obsPath))
            {
                missingFiles.Add(obsPath);
            }
            if (!File.Exists(scPath))
            {
                missingFiles.Add(scPath);
            }

            // Если есть пути, где файлы не найдены
            if (missingFiles.Count > 0)
            {
                string message = "Не удалось найти следующие файлы:\n" + string.Join("\n", missingFiles);
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Если все файлы существуют, то сохраняем в Json
                JsonController jsonController = new JsonController(@"data\config.json");
                
                DataModel data = new DataModel(osuPath, obsPath, scPath);

                if(jsonController.Save(data))
                {
                    this.Close();
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
