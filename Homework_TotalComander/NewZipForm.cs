using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Homework_TotalComander
{
    public partial class NewZipForm : Form
    {
        public NewZipForm(List<string> SelectedItems, string Directory)
        {
            InitializeComponent();
            selectedItems = SelectedItems;
            directory = Directory;
        }
        List<string> selectedItems;
        string directory;


        private void createFail_btn_Click(object sender, EventArgs e)
        {
            if (fileName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Введите название файла");
            }
            else
            {
                try
                {
                    string text = fileName.Text;
                    int lastDotIndex = text.LastIndexOf('.');
                    if (lastDotIndex >= 0)
                    {
                        text = text.Substring(0, lastDotIndex);
                    }
                    text += ".zip"; // Используем оператор += для добавления ".zip" в конец строки
                    fileName.Text = text;

                    string zipPath = $@"{directory}{fileName.Text}";

                    using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                    {
                        foreach (string filePath in selectedItems)
                        {
                            string fileName = Path.GetFileName(filePath);
                            archive.CreateEntryFromFile(filePath, fileName);
                        }
                    }
                    MessageBox.Show("Архив успешно создан");
                    this.Close();
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

           
            }
        }
    }
}
