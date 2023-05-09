using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework_TotalComander
{
    public partial class RenameForm : Form
    {
        public RenameForm(string Directory)
        {
            InitializeComponent();
            directory = Directory;
        }
        string directory;
        private void renameFail_btn_Click(object sender, EventArgs e)
        {
            string fileExtension;
            if (fileName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Введите новое название файла");
            }
            else
            {

                int lastDotIndex = directory.LastIndexOf('.'); // находим индекс последней точки в строке

                if (lastDotIndex >= 0)
                {
                    fileExtension = directory.Substring(lastDotIndex);
                    string text = fileName.Text;
                    text += fileExtension; 
                    fileName.Text = text;
                }

                try
                {
                    string path = $"{directory}{fileName.Text}";

                    if (!File.Exists(path))
                    {

                        string directoryPath = Path.GetDirectoryName(directory);
                        string newFilePath = Path.Combine(directoryPath, fileName.Text);

                        File.Move(directory, newFilePath);
                        MessageBox.Show("Файл успешно переименован");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такой файл уже существует");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
               