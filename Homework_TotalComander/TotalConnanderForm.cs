using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.IO.Compression;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Net.NetworkInformation;

namespace Homework_TotalComander
{
    public partial class TotalCommanderForm : Form
    {
        public TotalCommanderForm()
        {
            InitializeComponent();
        }
        private bool inWindow1 = false;
        private bool inWindow2 = false;
        private int clickMain;
        private int clickFile;
        string MainFailPath;
        private string path1, path2;
        List<string> selectedItems = new List<string>();
        List<string> selectedItemsForCopy = new List<string>();
        private ImageList icons1 = new ImageList(), icons2 = new ImageList();
        private string filePath;
        XmlDocument xmlDoc = new XmlDocument();
        string filePathXML = @"C:\Users\farra\source\repos\Homework_TotalComander\Homework_TotalComander\Preferences.xml";

        public DriveInfo[] LoadDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                drivesCB1.Items.Add(drive);
                drivesCB2.Items.Add(drive);
            }
            return drives;
        }

        private bool ItemsFilter(string path)
        {
            FileAttributes fileAttr = File.GetAttributes(path);
            if (fileAttr.HasFlag(FileAttributes.Hidden))
            {
                return false;
            }
            return true;
        }
        async public void LoadFiles(System.Windows.Forms.ListView explorer, string path)
        {
            if (Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                directories = directories.Where(ItemsFilter).ToArray();

                ImageList icons = explorer.SmallImageList;
                explorer.Items.Clear();
                if (icons != null) icons.Images.Clear();
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                {
                    icons.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                    explorer.Items.Add(files[i].Replace(path, ""), i);
                }
                icons.Images.Add(Properties.Resources.folder);
                foreach (string directory in directories)
                {
                    explorer.Items.Add(directory.Replace(path, ""), icons.Images.Count - 1);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }
        private void Update()
        {
            path1 = pathBox1.Text;
            if (File.Exists(path1))
            {
                Process.Start(path1);
                path1 = Directory.GetParent(path1).FullName + "\\";
                pathBox1.Text = path1;
            }
            LoadFiles(Window1, path1);
            path2 = pathBox2.Text;
            if (File.Exists(path2))
            {
                Process.Start(path2);
                path2 = Directory.GetParent(path2).FullName + "\\";
                pathBox2.Text = path2;
            }
            LoadFiles(Window2, path2);
        }
        private void ChangeFont()
        {
            xmlDoc.Load(filePathXML);
            XmlNode fontNode = xmlDoc.SelectSingleNode("//font");
            string fontString = fontNode.InnerText; 
            Font font = GetFontFromString(fontString);
            Window1.Font = font;
            Window2.Font = font;
        }
        private Font GetFontFromString(string fontString)
        {
            string[] fontParts = fontString.Split(';');
            string fontName = fontParts[0].Trim();
            float fontSize = float.Parse(fontParts[1].Replace("pt", "").Trim());
            FontStyle fontStyle = FontStyle.Regular;
            if (fontParts.Length > 2)
            {
                if (fontParts[2].Contains("Bold"))
                {
                    fontStyle |= FontStyle.Bold;
                }
                if (fontParts[2].Contains("Italic"))
                {
                    fontStyle |= FontStyle.Italic;
                }
                if (fontParts[2].Contains("Underline"))
                {
                    fontStyle |= FontStyle.Underline;
                }
            }
            return new Font(fontName, fontSize, fontStyle);
        }

            private void TotalCommanderForm_Load(object sender, EventArgs e)
        {
            int formWidth = control_panel.Location.X + control_panel.Width;
            int formHeight = control_panel.Location.Y + control_panel.Height;
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            DriveInfo[] drives = LoadDrives();
            drives.OrderBy(s => s.TotalSize);
            drivesCB1.SelectedItem = drives[0];
            drivesCB2.SelectedItem = drives[0];

            Window1.Scrollable = true;
            Window1.View = View.Details;
            Window2.Scrollable = true;
            Window2.View = View.Details;
            Window1.SmallImageList = icons1;
            Window2.SmallImageList = icons2;

            path1 = drives[0].Name;
            path2 = drives[0].Name;
            pathBox1.Text = path1;
            pathBox2.Text = path2;
            LoadFiles(Window1, path1);
            LoadFiles(Window2, path2);

            
            xmlDoc.Load(filePathXML);
            XmlNode directoryNode = xmlDoc.SelectSingleNode("/prefernces/directory");
            string directoryValue = directoryNode.InnerText;
            directoryBox.Text = directoryValue;
            pathBox1.Text = directoryValue;
            pathBox2.Text = directoryValue;
            MainFailPath = directoryValue;


            Update();


            XmlNode colorNode = xmlDoc.SelectSingleNode("//color");
            if (colorNode.InnerText == "VB")
            {
                ColorVB();
            }
            else if (colorNode.InnerText == "BV")
            {
                ColorBV();
            }
            ChangeFont();
            XmlNode fontNode = xmlDoc.SelectSingleNode("/prefernces/font");
            string fontValue = fontNode.InnerText;
            fontBox.Text = fontValue;

            
        }

        private void ColorVB()
        {
            Window1.ForeColor = Color.Black;
            Window2.ForeColor = Color.Black;
            upper_panel1.BackColor = Color.FromArgb(62, 6, 140);
            createFail_btn.BackgroundImage = Properties.Resources.violet_substate;
            copy_btn.BackgroundImage = Properties.Resources.violet_substate;
            postpone_btn.BackgroundImage = Properties.Resources.violet_substate;
            createDirectory_btn.BackgroundImage = Properties.Resources.violet_substate;
            archive_btn.BackgroundImage = Properties.Resources.violet_substate;
            copy_btn.BackgroundImage = Properties.Resources.violet_substate;
            back_btn1.BackgroundImage = Properties.Resources.violet_back;
            back_btn2.BackgroundImage = Properties.Resources.violet_back;
        }

        private void ColorBV()
        {
            Window1.ForeColor = Color.FromArgb(62, 6, 140);
            Window2.ForeColor = Color.FromArgb(62, 6, 140);
            upper_panel1.BackColor = Color.Black;
            createFail_btn.BackgroundImage = Properties.Resources.black_substrate;
            copy_btn.BackgroundImage = Properties.Resources.black_substrate;
            postpone_btn.BackgroundImage = Properties.Resources.black_substrate;
            archive_btn.BackgroundImage = Properties.Resources.black_substrate;
            createDirectory_btn.BackgroundImage = Properties.Resources.black_substrate;
            copy_btn.BackgroundImage = Properties.Resources.black_substrate;
            back_btn1.BackgroundImage = Properties.Resources.black_back;
            back_btn2.BackgroundImage = Properties.Resources.black_back;
        }
        private void options_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_directory_btn.Visible = false;
            directoryBox.Visible = false;
            colorsBV.Visible = false;
            colorsVB.Visible = false;
            original_font_btn.Visible = false;
            change_font_btn.Visible = false;
            fontBox.Visible = false;
            if (options_list.SelectedIndex==0)
            {
                colorsBV.Visible = true;
                colorsVB.Visible = true;
            }
            else if (options_list.SelectedIndex == 1)
            {
                original_font_btn.Visible = true;
                change_font_btn.Visible= true;
                fontBox.Visible = true;
            }
            else if (options_list.SelectedIndex == 2)
            {
                directoryBox.Visible = true;
                change_directory_btn.Visible = true;
            }
        }

        private void mainPicture_Click(object sender, EventArgs e)
        {
            mainPicture.BorderStyle = BorderStyle.None;
            clickMain += 1;
            if (clickMain == 3)
                clickMain = 1;
            if (clickMain == 1)
            {
                options_list.Visible = true;
                close_panel.Visible = true;
            }
                
            else if (clickMain == 2)
            {
                options_list.Visible = false;
                close_panel.Visible = false;
            }
            change_directory_btn.Visible = false;
            directoryBox.Visible = false;
            colorsBV.Visible = false;
            colorsVB.Visible = false;
            original_font_btn.Visible = false;
            change_font_btn.Visible = false;
            fontBox.Visible = false;

        }

       

        private void Window1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Window1.Items.Count; i++)
            {
                var rectangle = Window1.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string selectedFilePath = path1 + Window1.Items[i].Text + "\\";
                    FileAttributes fileAttr = File.GetAttributes(selectedFilePath);
                    if (fileAttr.HasFlag(FileAttributes.Directory))
                    {
                        path1 = selectedFilePath;
                        pathBox1.Text = path1;
                        LoadFiles(Window1, selectedFilePath);
                    }
                    else
                    {
                        try
                        {
                            Process.Start(selectedFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    return;
                }
            }
        }

        private void Window2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Window2.Items.Count; i++)
            {
                var rectangle = Window2.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string selectedFilePath = path2 + Window2.Items[i].Text + "\\";
                    FileAttributes fileAttr = File.GetAttributes(selectedFilePath);
                    if (fileAttr.HasFlag(FileAttributes.Directory))
                    {
                        path2 = selectedFilePath;
                        pathBox2.Text = path2;
                        LoadFiles(Window2, selectedFilePath);
                    }
                    else
                    {
                        try
                        {
                            Process.Start(selectedFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    return;
                }
            }
        }

        private void show_btn1_Click(object sender, EventArgs e)
        {
            path1 = pathBox1.Text;
            if (File.Exists(path1))
            {
                Process.Start(path1);
                path1 = Directory.GetParent(path1).FullName + "\\";
                pathBox1.Text = path1;
            }
            LoadFiles(Window1, path1);
        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            path2 = pathBox2.Text;
            if (File.Exists(path2))
            {
                Process.Start(path2);
                path2 = Directory.GetParent(path2).FullName + "\\";
                pathBox2.Text = path2;
            }
            LoadFiles(Window2, path2);
        }

        private void back_btn1_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(path1) != null)
            {
                while (path1[path1.Length - 1].Equals('\\') || path1[path1.Length - 1].Equals('/'))
                {
                    path1 = path1.Remove(path1.Length - 1);
                }
                path1 = Directory.GetParent(path1).FullName + "\\";
                pathBox1.Text = path1;
                LoadFiles(Window1, path1);
            }
        }

        private void back_btn2_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(path2) != null)
            {
                while (path2[path2.Length - 1].Equals('\\') || path2[path2.Length - 1].Equals('/'))
                {
                    path2 = path2.Remove(path2.Length - 1);
                }
                path2 = Directory.GetParent(path2).FullName + "\\";
                pathBox2.Text = path2;
                LoadFiles(Window2, path2);
            }
        }

       

        private void Window1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            inWindow1 = true;
            inWindow2 = false;
            selectedItems.Clear();
            foreach (ListViewItem item in Window1.Items)
            {
                if (item.Selected)
                {
                    selectedItems.Add($"{pathBox1.Text}{item.Text}");
                }
            }


            if (Window1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Window1.SelectedItems[0];
                string selectedText = selectedItem.Text;
                MainFailPath = pathBox1.Text;
                filePath = $"{pathBox1.Text}{selectedText}";
            }

        }

        private void Window2_SelectedIndexChanged(object sender, EventArgs e)
        {
            inWindow1 = false;
            inWindow2 = true;
            selectedItems.Clear();
            foreach (ListViewItem item in Window1.Items)
            {
                if (item.Selected)
                {
                    selectedItems.Add($"{pathBox1.Text}{item.Text}");
                }
            }

            if (Window2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Window2.SelectedItems[0];
                string selectedText = selectedItem.Text;
                filePath = $"{pathBox2.Text}{selectedText}";
                MainFailPath = pathBox2.Text;
            }
        }

        private void colorsVB_Click(object sender, EventArgs e)
        {
            XmlNode colorNode = xmlDoc.SelectSingleNode("//color");
            colorNode.InnerText = "VB";
            xmlDoc.Save(filePathXML);
            ColorVB();
        }

        private void colorsBV_Click(object sender, EventArgs e)
        {
            XmlNode colorNode = xmlDoc.SelectSingleNode("//color");
            colorNode.InnerText = "BV";
            xmlDoc.Save(filePathXML);
            ColorBV();
        }

        private void change_font_btn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = false;
            fontDialog.ShowEffects = false;
            fontDialog.Font = new Font("Microsoft Sans Serif", 10.125f);

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument preferences = XDocument.Load(filePathXML);
                preferences.Root.Element("font").Value = fontDialog.Font.Name + "; " + fontDialog.Font.SizeInPoints + "pt";
                preferences.Save(filePathXML);
            }

            ChangeFont();
            XmlNode fontNode = xmlDoc.SelectSingleNode("/prefernces/font");
            string fontValue = fontNode.InnerText;
            fontBox.Text = fontValue;
        }

        private void original_font_btn_Click(object sender, EventArgs e)
        {
            XmlNode fontNode = xmlDoc.SelectSingleNode("//font");
            fontNode.InnerText = "Microsoft Sans Serif; 10,125pt";
            xmlDoc.Save(filePathXML);
            ChangeFont();
            string fontValue = fontNode.InnerText;
            fontBox.Text = fontValue;
        }

        private void change_directory_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.SelectedPath = "C:\\";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument preferences = XDocument.Load(filePathXML);
                preferences.Root.Element("directory").Value = folderBrowserDialog.SelectedPath+"\\";
                preferences.Save(filePathXML);
            }
            xmlDoc.Load(filePathXML);
            XmlNode directoryNode = xmlDoc.SelectSingleNode("/prefernces/directory");
            string directoryValue = directoryNode.InnerText;
            directoryBox.Text = directoryValue;

            pathBox1.Text = directoryValue;
            pathBox2.Text = directoryValue;
            path1 = pathBox1.Text;
            Update();
        }

        private void createFail_btn_Click(object sender, EventArgs e)
        {
            NewFileForm newFileForm = new NewFileForm(MainFailPath);
            newFileForm.ShowDialog();

            
        }

        private void createDirectory_btn_Click(object sender, EventArgs e)
        {
            NewDirForm newDirForm = new NewDirForm(MainFailPath);
            newDirForm.ShowDialog();
        }

        private void file_btn_Click(object sender, EventArgs e)
        {
            operationsWithfile_list.ClearSelected();
            if (filePath != null)
            {
                operationsWithfile_list.ClearSelected();
                operationsWithfile_list.SelectedIndex = 0;
                clickFile += 1;
                if (clickFile == 3)
                {
                    
                    clickFile = 1;
                }
                    
                if (clickFile == 1)
                {
                    operationsWithfile_list.ClearSelected();
                    operationsWithfile_list.Visible = true;
                    
                }

                else if (clickFile == 2)
                {
                    operationsWithfile_list.ClearSelected();
                    operationsWithfile_list.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите файл");
            }
            
        }

        private async void operationsWithfile_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (operationsWithfile_list.SelectedIndex == 1)
            {
                 FileInfo fileInfo = new FileInfo(filePath);
                try
                {
                    MessageBox.Show("Имя файла: " + fileInfo.Name + "\n"
                                  + "Расширение файла: " + fileInfo.Extension + "\n"
                                  + "Полный путь к файлу: " + fileInfo.FullName + "\n"
                                  + "Размер файла: " + fileInfo.Length + " байт" + "\n"
                                  + "Дата создания: " + fileInfo.CreationTime + "\n"
                                  + "Дата последнего изменения: " + fileInfo.LastWriteTime + "\n"
                                  + "Дата последнего доступа: " + fileInfo.LastAccessTime);
                }
                 catch 
                {
                    MessageBox.Show("Выберите файл");
                }
                
            }
            else if (operationsWithfile_list.SelectedIndex == 2)
            {
                 RenameForm renameForm = new RenameForm(filePath);
                 renameForm.ShowDialog();
                 Update();
              
            }
            else if (operationsWithfile_list.SelectedIndex == 3)
            {
                
                    DialogResult result = MessageBox.Show("Удалить файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        await Task.Run(() =>
                        {// запускаем задачу в отдельном потоке 
                            try
                            {
                                File.Delete(filePath);
                                MessageBox.Show("Файл успешно удален");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        });
                        Update();
                    }
               
            }
           
        }

        private void archive_btn_Click(object sender, EventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Выберите файл/файлы для сжатия");
            }
            else
            {
                NewZipForm newDirForm = new NewZipForm(selectedItems, MainFailPath);
                newDirForm.ShowDialog();
                Update();
            }
            
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorkerDoWorkCopy);
            bgWorker.RunWorkerAsync();
        }
        private void bgWorkerDoWorkCopy(object sender, DoWorkEventArgs e)
        {
            // Код для выполнения операции в отдельном потоке
            Invoke(new Action(() =>
            {
                selectedItemsForCopy.Clear();
                if (inWindow1)
                {
                    foreach (ListViewItem item in Window1.Items)
                    {
                        if (item.Selected)
                        {
                            selectedItemsForCopy.Add($"{pathBox1.Text}{item.Text}");
                        }
                    }
                }
                else if (inWindow2)
                {
                    foreach (ListViewItem item in Window2.Items)
                    {
                        if (item.Selected)
                        {
                            selectedItemsForCopy.Add($"{pathBox2.Text}{item.Text}");
                        }
                    }
                }
                if (selectedItemsForCopy.Count == 0)
                {
                    MessageBox.Show("Вы ничего не выбрали");
                }
            }));
        }
        private void postpone_btn_Click(object sender, EventArgs e)
        {
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorkerDoWorkPostpone);
            bgWorker.RunWorkerAsync(selectedItemsForCopy);

        }

        private void bgWorkerDoWorkPostpone(object sender, DoWorkEventArgs e)
        {
            List<string> itemsToCopy = e.Argument as List<string>;

            // Код для выполнения операции в отдельном потоке
            if (inWindow1)
            {
                try
                {
                    foreach (string filePath in itemsToCopy)
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationPath = Path.Combine(pathBox2.Text, fileName);
                        File.Copy(filePath, destinationPath);
                    }
                    Invoke(new Action(() => {
                        Update();
                        MessageBox.Show("Файлы успешно добавлены");
                    }));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => {
                        MessageBox.Show(ex.Message);
                    }));
                }
            }
            else if (inWindow2)
            {
                try
                {
                    foreach (string filePath in itemsToCopy)
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationPath = Path.Combine(pathBox1.Text, fileName);
                        File.Copy(filePath, destinationPath);
                    }
                    Invoke(new Action(() => {
                        Update();
                        MessageBox.Show("Файлы успешно добавлены");
                    }));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => {
                        MessageBox.Show(ex.Message);
                    }));
                }
            }
            else
            {
                Invoke(new Action(() => {
                    MessageBox.Show("Вы ничего не выбрали");
                }));
            }
        }

        private void mainPicture_MouseEnter(object sender, EventArgs e)
        {
            mainPicture.BorderStyle = BorderStyle.Fixed3D;
        }

        private void mainPicture_MouseLeave(object sender, EventArgs e)
        {
            mainPicture.BorderStyle = BorderStyle.None;
        }

       
    }
}
