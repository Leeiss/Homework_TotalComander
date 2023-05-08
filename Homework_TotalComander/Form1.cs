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

namespace Homework_TotalComander
{
    public partial class TotalCommanderForm : Form
    {
        public TotalCommanderForm()
        {
            InitializeComponent();
        }
        private int clickMain;
        private string path1, path2;
        private ImageList icons1 = new ImageList(), icons2 = new ImageList();

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
        async public void LoadFiles(ListView explorer, string path)
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

        }
        
        private void options_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mainPicture_Click(object sender, EventArgs e)
        {
            mainPicture.BorderStyle = BorderStyle.None;
            clickMain += 1;
            if (clickMain == 3)
                clickMain = 1;
            if (clickMain == 1)
                options_list.Visible = true;
            else if (clickMain == 2)
                options_list.Visible = false;
            
        }

        private void Window1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
