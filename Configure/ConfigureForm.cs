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
                // ���� ������ �������� ���� �� ����� � .exe ������
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
            // ���� � ������
            string osuPath = Path.Combine(PathToOsu.Text, "osu!.exe");
            string obsPath = Path.Combine(PathToOBS.Text, "obs64.exe");
            string scPath = Path.Combine(PathToSC.Text, "StreamCompanion.exe");

            // ������ �����, ��� �� ������� �����
            List<string> missingFiles = new List<string>();

            // �������� ������������� ������� �����
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

            // ���� ���� ����, ��� ����� �� �������
            if (missingFiles.Count > 0)
            {
                string message = "�� ������� ����� ��������� �����:\n" + string.Join("\n", missingFiles);
                MessageBox.Show(message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ���� ��� ����� ����������, �� ��������� � Json
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
