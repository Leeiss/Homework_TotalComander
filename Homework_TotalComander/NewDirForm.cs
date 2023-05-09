using System;
using System.IO;
using System.Windows.Forms;

namespace Homework_TotalComander
{
    public partial class NewDirForm : Form
    {
        public NewDirForm(string directory)
        {
            InitializeComponent();
            Directory = directory;
        }
        string Directory;

        private void createFail_btn_Click(object sender, EventArgs e)
        {
            if (folderName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Введите название папки");
            }
            else
            {
                string dirPath = $"{Directory}{folderName.Text}";
                try
                {
                    if (!File.Exists(dirPath))
                    {

                        DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                        dirInfo.Create();
                        MessageBox.Show("Папка успешна создана");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Папка с таким именем уже существует");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            
        }

        private void NewDirForm_Load(object sender, EventArgs e)
        {

        }
    }
}
