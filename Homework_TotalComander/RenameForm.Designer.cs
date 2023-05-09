namespace Homework_TotalComander
{
    partial class RenameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameForm));
            this.fileName = new System.Windows.Forms.TextBox();
            this.renameFail_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileName.Location = new System.Drawing.Point(81, 81);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(438, 44);
            this.fileName.TabIndex = 17;
            // 
            // renameFail_btn
            // 
            this.renameFail_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.renameFail_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.renameFail_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.renameFail_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renameFail_btn.Font = new System.Drawing.Font("Pristina", 7F);
            this.renameFail_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.renameFail_btn.Location = new System.Drawing.Point(537, 69);
            this.renameFail_btn.Name = "renameFail_btn";
            this.renameFail_btn.Size = new System.Drawing.Size(194, 77);
            this.renameFail_btn.TabIndex = 16;
            this.renameFail_btn.TabStop = false;
            this.renameFail_btn.Text = "Переименовать";
            this.renameFail_btn.UseVisualStyleBackColor = false;
            this.renameFail_btn.Click += new System.EventHandler(this.renameFail_btn_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.renameFail_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.Text = "Переименовать файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button renameFail_btn;
    }
}