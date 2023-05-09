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

namespace Homework_TotalComander
{
    public partial class NewFileForm : Form
    {
        public NewFileForm(string directory)
        {
            InitializeComponent();
            Directory = directory;
        }
        string Directory;
        private void NewFileForm_Load(object sender, EventArgs e)
        {
          
        }

        private void createFail_btn_Click(object sender, EventArgs e)
        {
            if (fileName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Введите название файла");
            }
            else
            {
                string path = $"{Directory}{fileName.Text}";
                try
                {
                    if (!File.Exists(path))
                    {
                        string filePath = Path.Combine(Directory, fileName.Text);
                        if (!File.Exists(filePath))
                        {
                            File.Create(filePath).Close();
                        }
                        MessageBox.Show("Файл успешно создан");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такой файл уже существует");
                    }
                }

                catch
                {
                    MessageBox.Show("Некорректно введено название файла");
                }
            }
            
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
