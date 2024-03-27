namespace StudentsDiary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AccountBtn = new System.Windows.Forms.Button();
            this.TimingBtn = new System.Windows.Forms.Button();
            this.DiaryBtn = new System.Windows.Forms.Button();
            this.GradBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountBtn
            // 
            this.AccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.user__1_;
            this.AccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AccountBtn.FlatAppearance.BorderSize = 4;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Location = new System.Drawing.Point(179, 179);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(118, 98);
            this.AccountBtn.TabIndex = 0;
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // TimingBtn
            // 
            this.TimingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimingBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimingBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.schedule;
            this.TimingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TimingBtn.FlatAppearance.BorderSize = 4;
            this.TimingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimingBtn.Location = new System.Drawing.Point(366, 179);
            this.TimingBtn.Name = "TimingBtn";
            this.TimingBtn.Size = new System.Drawing.Size(116, 98);
            this.TimingBtn.TabIndex = 1;
            this.TimingBtn.UseVisualStyleBackColor = false;
            this.TimingBtn.Click += new System.EventHandler(this.TimingBtn_Click);
            // 
            // DiaryBtn
            // 
            this.DiaryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiaryBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiaryBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.report_card;
            this.DiaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiaryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DiaryBtn.FlatAppearance.BorderSize = 4;
            this.DiaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiaryBtn.Location = new System.Drawing.Point(557, 179);
            this.DiaryBtn.Name = "DiaryBtn";
            this.DiaryBtn.Size = new System.Drawing.Size(118, 100);
            this.DiaryBtn.TabIndex = 2;
            this.DiaryBtn.UseVisualStyleBackColor = false;
            this.DiaryBtn.Click += new System.EventHandler(this.DiaryBtn_Click);
            // 
            // GradBtn
            // 
            this.GradBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GradBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.graduate2;
            this.GradBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GradBtn.FlatAppearance.BorderSize = 0;
            this.GradBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradBtn.Location = new System.Drawing.Point(13, 6);
            this.GradBtn.Name = "GradBtn";
            this.GradBtn.Size = new System.Drawing.Size(108, 98);
            this.GradBtn.TabIndex = 4;
            this.GradBtn.UseVisualStyleBackColor = false;
            this.GradBtn.Click += new System.EventHandler(this.GradBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsDiary.Properties.Resources.MainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradBtn);
            this.Controls.Add(this.DiaryBtn);
            this.Controls.Add(this.TimingBtn);
            this.Controls.Add(this.AccountBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button TimingBtn;
        private System.Windows.Forms.Button DiaryBtn;
        private System.Windows.Forms.Button GradBtn;
    }
}