﻿namespace Homework_TotalComander
{
    partial class NewDirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDirForm));
            this.folderName = new System.Windows.Forms.TextBox();
            this.createFail_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderName
            // 
            this.folderName.BackColor = System.Drawing.Color.White;
            this.folderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderName.Location = new System.Drawing.Point(85, 71);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(438, 44);
            this.folderName.TabIndex = 15;
            // 
            // createFail_btn
            // 
            this.createFail_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.createFail_btn.BackgroundImage = global::Homework_TotalComander.Properties.Resources.violet_substate;
            this.createFail_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createFail_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createFail_btn.Font = new System.Drawing.Font("Pristina", 7F);
            this.createFail_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createFail_btn.Location = new System.Drawing.Point(541, 59);
            this.createFail_btn.Name = "createFail_btn";
            this.createFail_btn.Size = new System.Drawing.Size(182, 77);
            this.createFail_btn.TabIndex = 14;
            this.createFail_btn.TabStop = false;
            this.createFail_btn.Text = "Создать папку";
            this.createFail_btn.UseVisualStyleBackColor = false;
            this.createFail_btn.Click += new System.EventHandler(this.createFail_btn_Click);
            // 
            // NewDirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.createFail_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewDirForm";
            this.Text = "Создание папки";
            this.Load += new System.EventHandler(this.NewDirForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Button createFail_btn;
    }
}