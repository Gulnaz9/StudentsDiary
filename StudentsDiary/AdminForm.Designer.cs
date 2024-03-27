namespace StudentsDiary
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AdminLogTextBox = new System.Windows.Forms.TextBox();
            this.AdminPassTextBox = new System.Windows.Forms.TextBox();
            this.AdminEnterBtn = new System.Windows.Forms.Button();
            this.LoginPicBox = new System.Windows.Forms.PictureBox();
            this.AdminLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLogTextBox
            // 
            this.AdminLogTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminLogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLogTextBox.Location = new System.Drawing.Point(342, 332);
            this.AdminLogTextBox.Multiline = true;
            this.AdminLogTextBox.Name = "AdminLogTextBox";
            this.AdminLogTextBox.Size = new System.Drawing.Size(234, 45);
            this.AdminLogTextBox.TabIndex = 0;
            this.AdminLogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminPassTextBox
            // 
            this.AdminPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminPassTextBox.Location = new System.Drawing.Point(342, 393);
            this.AdminPassTextBox.Name = "AdminPassTextBox";
            this.AdminPassTextBox.Size = new System.Drawing.Size(234, 30);
            this.AdminPassTextBox.TabIndex = 1;
            this.AdminPassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminPassTextBox.UseSystemPasswordChar = true;
            // 
            // AdminEnterBtn
            // 
            this.AdminEnterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminEnterBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminEnterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AdminEnterBtn.FlatAppearance.BorderSize = 3;
            this.AdminEnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminEnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminEnterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AdminEnterBtn.Location = new System.Drawing.Point(403, 443);
            this.AdminEnterBtn.Name = "AdminEnterBtn";
            this.AdminEnterBtn.Size = new System.Drawing.Size(132, 46);
            this.AdminEnterBtn.TabIndex = 2;
            this.AdminEnterBtn.Text = "ВОЙТИ";
            this.AdminEnterBtn.UseVisualStyleBackColor = false;
            this.AdminEnterBtn.Click += new System.EventHandler(this.AdminEnterBtn_Click);
            // 
            // LoginPicBox
            // 
            this.LoginPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPicBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPicBox.Image = global::StudentsDiary.Properties.Resources.graduate1;
            this.LoginPicBox.Location = new System.Drawing.Point(393, 183);
            this.LoginPicBox.Name = "LoginPicBox";
            this.LoginPicBox.Size = new System.Drawing.Size(142, 125);
            this.LoginPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicBox.TabIndex = 3;
            this.LoginPicBox.TabStop = false;
            // 
            // AdminLbl
            // 
            this.AdminLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLbl.AutoSize = true;
            this.AdminLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AdminLbl.Location = new System.Drawing.Point(347, 50);
            this.AdminLbl.Name = "AdminLbl";
            this.AdminLbl.Size = new System.Drawing.Size(219, 29);
            this.AdminLbl.TabIndex = 4;
            this.AdminLbl.Text = "Администратору";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsDiary.Properties.Resources.LoginBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 596);
            this.Controls.Add(this.AdminLbl);
            this.Controls.Add(this.LoginPicBox);
            this.Controls.Add(this.AdminEnterBtn);
            this.Controls.Add(this.AdminPassTextBox);
            this.Controls.Add(this.AdminLogTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminLogTextBox;
        private System.Windows.Forms.TextBox AdminPassTextBox;
        private System.Windows.Forms.Button AdminEnterBtn;
        private System.Windows.Forms.PictureBox LoginPicBox;
        private System.Windows.Forms.Label AdminLbl;
    }
}