namespace Homework_TotalComander
{
    partial class TotalCommanderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalCommanderForm));
            this.upperpanel = new System.Windows.Forms.Panel();
            this.upper_panel1 = new System.Windows.Forms.Panel();
            this.control_panel = new System.Windows.Forms.Panel();
            this.options_list = new System.Windows.Forms.ListBox();
            this.pathBox1 = new System.Windows.Forms.TextBox();
            this.show_btn1 = new System.Windows.Forms.Button();
            this.show_btn2 = new System.Windows.Forms.Button();
            this.pathBox2 = new System.Windows.Forms.TextBox();
            this.drivesCB1 = new System.Windows.Forms.ComboBox();
            this.drivesCB2 = new System.Windows.Forms.ComboBox();
            this.Window1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Window2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change_directory_btn = new System.Windows.Forms.Button();
            this.directoryBox = new System.Windows.Forms.RichTextBox();
            this.close_panel = new System.Windows.Forms.Panel();
            this.fontBox = new System.Windows.Forms.RichTextBox();
            this.change_font_btn = new System.Windows.Forms.Button();
            this.original_font_btn = new System.Windows.Forms.Button();
            this.operationsWithfile_list = new System.Windows.Forms.ListBox();
            this.colorsBV = new System.Windows.Forms.Button();
            this.colorsVB = new System.Windows.Forms.Button();
            this.back_btn2 = new System.Windows.Forms.Button();
            this.back_btn1 = new System.Windows.Forms.Button();
            this.archive_btn = new System.Windows.Forms.Button();
            this.file_btn = new System.Windows.Forms.Button();
            this.postpone_btn = new System.Windows.Forms.Button();
            this.createDirectory_btn = new System.Windows.Forms.Button();
            this.createFail_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.upperpanel.SuspendLayout();
            this.close_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.upperpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upperpanel.Controls.Add(this.archive_btn);
            this.upperpanel.Controls.Add(this.file_btn);
            this.upperpanel.Controls.Add(this.postpone_btn);
            this.upperpanel.Controls.Add(this.createDirectory_btn);
            this.upperpanel.Controls.Add(this.upper_panel1);
            this.upperpanel.Controls.Add(this.createFail_btn);
            this.upperpanel.Controls.Add(this.copy_btn);
            this.upperpanel.Controls.Add(this.mainPicture);
            this.upperpanel.Location = new System.Drawing.Point(0, 1);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1794, 112);
            this.upperpanel.TabIndex = 0;
            // 
            // upper_panel1
            // 
            this.upper_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upper_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(140)))));
            this.upper_panel1.Location = new System.Drawing.Point(142, 101);
            this.upper_panel1.Name = "upper_panel1";
            this.upper_panel1.Size = new System.Drawing.Size(1652, 14);
            this.upper_panel1.TabIndex = 1;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.Window;
            this.control_panel.Location = new System.Drawing.Point(1724, 918);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(64, 54);
            this.control_panel.TabIndex = 1;
            // 
            // options_list
            // 
            this.options_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(140)))));
            this.options_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.options_list.Font = new System.Drawing.Font("Pristina", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_list.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.options_list.FormattingEnabled = true;
            this.options_list.ItemHeight = 35;
            this.options_list.Items.AddRange(new object[] {
            "Цветовая схема",
            "Размер шрифта",
            "Директория по умолчанию"});
            this.options_list.Location = new System.Drawing.Point(144, 0);
            this.options_list.Name = "options_list";
            this.options_list.Size = new System.Drawing.Size(400, 105);
            this.options_list.TabIndex = 4;
            this.options_list.Visible = false;
            this.options_list.SelectedIndexChanged += new System.EventHandler(this.options_list_SelectedIndexChanged);
            // 
            // pathBox1
            // 
            this.pathBox1.BackColor = System.Drawing.Color.White;
            this.pathBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBox1.Location = new System.Drawing.Point(185, 124);
            this.pathBox1.Name = "pathBox1";
            this.pathBox1.Size = new System.Drawing.Size(506, 38);
            this.pathBox1.TabIndex = 8;
            this.pathBox1.TabStop = false;
            // 
            // show_btn1
            // 
            this.show_btn1.BackColor = System.Drawing.Color.White;
            this.show_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_btn1.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show_btn1.Location = new System.Drawing.Point(697, 124);
            this.show_btn1.Name = "show_btn1";
            this.show_btn1.Size = new System.Drawing.Size(134, 44);
            this.show_btn1.TabIndex = 6;
            this.show_btn1.TabStop = false;
            this.show_btn1.Text = "Открыть";
            this.show_btn1.UseVisualStyleBackColor = false;
            this.show_btn1.Click += new System.EventHandler(this.show_btn1_Click);
            // 
            // show_btn2
            // 
            this.show_btn2.BackColor = System.Drawing.Color.White;
            this.show_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_btn2.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show_btn2.Location = new System.Drawing.Point(1546, 125);
            this.show_btn2.Name = "show_btn2";
            this.show_btn2.Size = new System.Drawing.Size(134, 44);
            this.show_btn2.TabIndex = 11;
            this.show_btn2.TabStop = false;
            this.show_btn2.Text = "Открыть";
            this.show_btn2.UseVisualStyleBackColor = false;
            this.show_btn2.Click += new System.EventHandler(this.show_btn2_Click);
            // 
            // pathBox2
            // 
            this.pathBox2.BackColor = System.Drawing.Color.White;
            this.pathBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBox2.Location = new System.Drawing.Point(1034, 125);
            this.pathBox2.Name = "pathBox2";
            this.pathBox2.Size = new System.Drawing.Size(506, 38);
            this.pathBox2.TabIndex = 12;
            this.pathBox2.TabStop = false;
            // 
            // drivesCB1
            // 
            this.drivesCB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.drivesCB1.FormattingEnabled = true;
            this.drivesCB1.Location = new System.Drawing.Point(69, 125);
            this.drivesCB1.Margin = new System.Windows.Forms.Padding(6);
            this.drivesCB1.Name = "drivesCB1";
            this.drivesCB1.Size = new System.Drawing.Size(88, 39);
            this.drivesCB1.TabIndex = 16;
            // 
            // drivesCB2
            // 
            this.drivesCB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.drivesCB2.FormattingEnabled = true;
            this.drivesCB2.Location = new System.Drawing.Point(937, 123);
            this.drivesCB2.Margin = new System.Windows.Forms.Padding(6);
            this.drivesCB2.Name = "drivesCB2";
            this.drivesCB2.Size = new System.Drawing.Size(88, 39);
            this.drivesCB2.TabIndex = 17;
            // 
            // Window1
            // 
            this.Window1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Window1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Window1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Window1.HideSelection = false;
            this.Window1.Location = new System.Drawing.Point(-2, 172);
            this.Window1.Margin = new System.Windows.Forms.Padding(6);
            this.Window1.Name = "Window1";
            this.Window1.Size = new System.Drawing.Size(872, 860);
            this.Window1.TabIndex = 18;
            this.Window1.UseCompatibleStateImageBehavior = false;
            this.Window1.View = System.Windows.Forms.View.SmallIcon;
            this.Window1.SelectedIndexChanged += new System.EventHandler(this.Window1_SelectedIndexChanged_1);
            this.Window1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Window1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 200;
            // 
            // Window2
            // 
            this.Window2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Window2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.Window2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Window2.HideSelection = false;
            this.Window2.Location = new System.Drawing.Point(875, 172);
            this.Window2.Margin = new System.Windows.Forms.Padding(6);
            this.Window2.Name = "Window2";
            this.Window2.Size = new System.Drawing.Size(1018, 860);
            this.Window2.TabIndex = 19;
            this.Window2.UseCompatibleStateImageBehavior = false;
            this.Window2.View = System.Windows.Forms.View.SmallIcon;
            this.Window2.SelectedIndexChanged += new System.EventHandler(this.Window2_SelectedIndexChanged);
            this.Window2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Window2_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 200;
            // 
            // change_directory_btn
            // 
            this.change_directory_btn.BackColor = System.Drawing.SystemColors.Window;
            this.change_directory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_directory_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_directory_btn.Font = new System.Drawing.Font("Pristina", 8F);
            this.change_directory_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.change_directory_btn.Location = new System.Drawing.Point(142, 122);
            this.change_directory_btn.Name = "change_directory_btn";
            this.change_directory_btn.Size = new System.Drawing.Size(137, 49);
            this.change_directory_btn.TabIndex = 23;
            this.change_directory_btn.TabStop = false;
            this.change_directory_btn.Text = "Изменить";
            this.change_directory_btn.UseVisualStyleBackColor = false;
            this.change_directory_btn.Visible = false;
            this.change_directory_btn.Click += new System.EventHandler(this.change_directory_btn_Click);
            // 
            // directoryBox
            // 
            this.directoryBox.BackColor = System.Drawing.SystemColors.Window;
            this.directoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryBox.Location = new System.Drawing.Point(281, 117);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.ReadOnly = true;
            this.directoryBox.Size = new System.Drawing.Size(260, 67);
            this.directoryBox.TabIndex = 24;
            this.directoryBox.Text = "";
            this.directoryBox.Visible = false;
            // 
            // close_panel
            // 
            this.close_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close_panel.BackColor = System.Drawing.SystemColors.Control;
            this.close_panel.Controls.Add(this.original_font_btn);
            this.close_panel.Controls.Add(this.change_font_btn);
            this.close_panel.Controls.Add(this.fontBox);
            this.close_panel.Controls.Add(this.directoryBox);
            this.close_panel.Controls.Add(this.colorsBV);
            this.close_panel.Controls.Add(this.change_directory_btn);
            this.close_panel.Controls.Add(this.colorsVB);
            this.close_panel.Controls.Add(this.options_list);
            this.close_panel.Location = new System.Drawing.Point(0, 110);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(1834, 782);
            this.close_panel.TabIndex = 25;
            this.close_panel.Visible = false;
            // 
            // fontBox
            // 
            this.fontBox.BackColor = System.Drawing.SystemColors.Window;
            this.fontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontBox.Location = new System.Drawing.Point(281, 122);
            this.fontBox.Name = "fontBox";
            this.fontBox.ReadOnly = true;
            this.fontBox.Size = new System.Drawing.Size(260, 44);
            this.fontBox.TabIndex = 25;
            this.fontBox.Text = "";
            this.fontBox.Visible = false;
            // 
            // change_font_btn
            // 
            this.change_font_btn.BackColor = System.Drawing.SystemColors.Window;
            this.change_font_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_font_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_font_btn.Font = new System.Drawing.Font("Pristina", 8F);
            this.change_font_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.change_font_btn.Location = new System.Drawing.Point(142, 167);
            this.change_font_btn.Name = "change_font_btn";
            this.change_font_btn.Size = new System.Drawing.Size(137, 76);
            this.change_font_btn.TabIndex = 26;
            this.change_font_btn.TabStop = false;
            this.change_font_btn.Text = "Изменить";
            this.change_font_btn.UseVisualStyleBackColor = false;
            this.change_font_btn.Visible = false;
            this.change_font_btn.Click += new System.EventHandler(this.change_font_btn_Click);
            // 
            // original_font_btn
            // 
            this.original_font_btn.BackColor = System.Drawing.SystemColors.Window;
            this.original_font_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.original_font_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.original_font_btn.Font = new System.Drawing.Font("Pristina", 8F);
            this.original_font_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.original_font_btn.Location = new System.Drawing.Point(274, 167);
            this.original_font_btn.Name = "original_font_btn";
            this.original_font_btn.Size = new System.Drawing.Size(267, 76);
            this.original_font_btn.TabIndex = 27;
            this.original_font_btn.TabStop = false;
            this.original_font_btn.Text = "Сбросить до начальных настроек шрифта";
            this.original_font_btn.UseVisualStyleBackColor = false;
            this.original_font_btn.Visible = false;
            this.original_font_btn.Click += new System.EventHandler(this.original_font_btn_Click);
            // 
            // operationsWithfile_list
            // 
            this.operationsWithfile_list.BackColor = System.Drawing.SystemColors.Control;
            this.operationsWithfile_list.Cursor = System.Windows.Forms.Cursors.Default;
            this.operationsWithfile_list.Font = new System.Drawing.Font("Pristina", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsWithfile_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operationsWithfile_list.FormattingEnabled = true;
            this.operationsWithfile_list.ItemHeight = 32;
            this.operationsWithfile_list.Items.AddRange(new object[] {
            "",
            "Свойства файла",
            "Переимновать",
            "Удалить"});
            this.operationsWithfile_list.Location = new System.Drawing.Point(550, 87);
            this.operationsWithfile_list.Name = "operationsWithfile_list";
            this.operationsWithfile_list.Size = new System.Drawing.Size(219, 132);
            this.operationsWithfile_list.TabIndex = 28;
            this.operationsWithfile_list.TabStop = false;
            this.operationsWithfile_list.Visible = false;
            this.operationsWithfile_list.SelectedIndexChanged += new System.EventHandler(this.operationsWithfile_list_SelectedIndexChanged);
            // 
            // colorsBV
            // 
            this.colorsBV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorsBV.BackgroundImage")));
            this.colorsBV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorsBV.Location = new System.Drawing.Point(332, 116);
            this.colorsBV.Name = "colorsBV";
            this.colorsBV.Size = new System.Drawing.Size(95, 55);
            this.colorsBV.TabIndex = 22;
            this.colorsBV.UseVisualStyleBackColor = true;
            this.colorsBV.Visible = false;
            this.colorsBV.Click += new System.EventHandler(this.colorsBV_Click);
            // 
            // colorsVB
            // 
            this.colorsVB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorsVB.BackgroundImage")));
            this.colorsVB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorsVB.Location = new System.Drawing.Point(219, 116);
            this.colorsVB.Name = "colorsVB";
            this.colorsVB.Size = new System.Drawing.Size(95, 55);
            this.colorsVB.TabIndex = 21;
            this.colorsVB.UseVisualStyleBackColor = true;
            this.colorsVB.Visible = false;
            this.colorsVB.Click += new System.EventHandler(this.colorsVB_Click);
            // 
            // back_btn2
            // 
            this.back_btn2.BackColor = System.Drawing.Color.White;
            this.back_btn2.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_back;
            this.back_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn2.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn2.Location = new System.Drawing.Point(875, 119);
            this.back_btn2.Name = "back_btn2";
            this.back_btn2.Size = new System.Drawing.Size(53, 50);
            this.back_btn2.TabIndex = 13;
            this.back_btn2.TabStop = false;
            this.back_btn2.UseVisualStyleBackColor = false;
            this.back_btn2.Click += new System.EventHandler(this.back_btn2_Click);
            // 
            // back_btn1
            // 
            this.back_btn1.BackColor = System.Drawing.Color.White;
            this.back_btn1.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_back;
            this.back_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn1.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn1.Location = new System.Drawing.Point(7, 119);
            this.back_btn1.Name = "back_btn1";
            this.back_btn1.Size = new System.Drawing.Size(53, 50);
            this.back_btn1.TabIndex = 9;
            this.back_btn1.TabStop = false;
            this.back_btn1.UseVisualStyleBackColor = false;
            this.back_btn1.Click += new System.EventHandler(this.back_btn1_Click);
            // 
            // archive_btn
            // 
            this.archive_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.archive_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.archive_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.archive_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archive_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archive_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.archive_btn.Location = new System.Drawing.Point(1155, 26);
            this.archive_btn.Name = "archive_btn";
            this.archive_btn.Size = new System.Drawing.Size(204, 67);
            this.archive_btn.TabIndex = 7;
            this.archive_btn.TabStop = false;
            this.archive_btn.Text = "Сжать в архив ";
            this.archive_btn.UseVisualStyleBackColor = false;
            this.archive_btn.Click += new System.EventHandler(this.archive_btn_Click);
            // 
            // file_btn
            // 
            this.file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.file_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("file_btn.BackgroundImage")));
            this.file_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.file_btn.Location = new System.Drawing.Point(492, 35);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(73, 66);
            this.file_btn.TabIndex = 6;
            this.file_btn.TabStop = false;
            this.file_btn.UseVisualStyleBackColor = false;
            this.file_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // postpone_btn
            // 
            this.postpone_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.postpone_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.postpone_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postpone_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postpone_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postpone_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.postpone_btn.Location = new System.Drawing.Point(1589, 26);
            this.postpone_btn.Name = "postpone_btn";
            this.postpone_btn.Size = new System.Drawing.Size(199, 68);
            this.postpone_btn.TabIndex = 5;
            this.postpone_btn.TabStop = false;
            this.postpone_btn.Text = "Перенести";
            this.postpone_btn.UseVisualStyleBackColor = false;
            this.postpone_btn.Click += new System.EventHandler(this.postpone_btn_Click);
            // 
            // createDirectory_btn
            // 
            this.createDirectory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.createDirectory_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.createDirectory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createDirectory_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createDirectory_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDirectory_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createDirectory_btn.Location = new System.Drawing.Point(950, 26);
            this.createDirectory_btn.Name = "createDirectory_btn";
            this.createDirectory_btn.Size = new System.Drawing.Size(204, 67);
            this.createDirectory_btn.TabIndex = 4;
            this.createDirectory_btn.TabStop = false;
            this.createDirectory_btn.Text = "Создать папку";
            this.createDirectory_btn.UseVisualStyleBackColor = false;
            this.createDirectory_btn.Click += new System.EventHandler(this.createDirectory_btn_Click);
            // 
            // createFail_btn
            // 
            this.createFail_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.createFail_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.createFail_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createFail_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createFail_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFail_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createFail_btn.Location = new System.Drawing.Point(762, 27);
            this.createFail_btn.Name = "createFail_btn";
            this.createFail_btn.Size = new System.Drawing.Size(192, 68);
            this.createFail_btn.TabIndex = 3;
            this.createFail_btn.TabStop = false;
            this.createFail_btn.Text = "Создать файл";
            this.createFail_btn.UseVisualStyleBackColor = false;
            this.createFail_btn.Click += new System.EventHandler(this.createFail_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.copy_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.copy_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_btn.Font = new System.Drawing.Font("Pristina", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copy_btn.Location = new System.Drawing.Point(1414, 27);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(174, 68);
            this.copy_btn.TabIndex = 0;
            this.copy_btn.TabStop = false;
            this.copy_btn.Text = "Копировать";
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // mainPicture
            // 
            this.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPicture.Image = ((System.Drawing.Image)(resources.GetObject("mainPicture.Image")));
            this.mainPicture.Location = new System.Drawing.Point(12, 12);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(474, 90);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            this.mainPicture.Click += new System.EventHandler(this.mainPicture_Click);
            this.mainPicture.MouseEnter += new System.EventHandler(this.mainPicture_MouseEnter);
            this.mainPicture.MouseLeave += new System.EventHandler(this.mainPicture_MouseLeave);
            // 
            // TotalCommanderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1029);
            this.Controls.Add(this.upperpanel);
            this.Controls.Add(this.operationsWithfile_list);
            this.Controls.Add(this.close_panel);
            this.Controls.Add(this.Window2);
            this.Controls.Add(this.drivesCB2);
            this.Controls.Add(this.drivesCB1);
            this.Controls.Add(this.back_btn2);
            this.Controls.Add(this.show_btn2);
            this.Controls.Add(this.pathBox2);
            this.Controls.Add(this.back_btn1);
            this.Controls.Add(this.show_btn1);
            this.Controls.Add(this.pathBox1);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.Window1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalCommanderForm";
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.TotalCommanderForm_Load);
            this.upperpanel.ResumeLayout(false);
            this.close_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.Button createFail_btn;
        private System.Windows.Forms.Panel upper_panel1;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.ListBox options_list;
        private System.Windows.Forms.Button createDirectory_btn;
        private System.Windows.Forms.Button postpone_btn;
        private System.Windows.Forms.TextBox pathBox1;
        private System.Windows.Forms.Button show_btn1;
        private System.Windows.Forms.Button back_btn1;
        private System.Windows.Forms.Button back_btn2;
        private System.Windows.Forms.Button show_btn2;
        private System.Windows.Forms.TextBox pathBox2;
        private System.Windows.Forms.ComboBox drivesCB1;
        private System.Windows.Forms.ComboBox drivesCB2;
        private System.Windows.Forms.ListView Window1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView Window2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button colorsVB;
        private System.Windows.Forms.Button colorsBV;
        private System.Windows.Forms.Button change_directory_btn;
        private System.Windows.Forms.RichTextBox directoryBox;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Button original_font_btn;
        private System.Windows.Forms.Button change_font_btn;
        private System.Windows.Forms.RichTextBox fontBox;
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.ListBox operationsWithfile_list;
        private System.Windows.Forms.Button archive_btn;
    }
}

