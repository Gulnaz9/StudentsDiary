namespace StudentsDiary
{
    partial class ChangeGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeGroupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddLbl = new System.Windows.Forms.Label();
            this.DeleteLbl = new System.Windows.Forms.Label();
            this.DeleteStudBtn = new System.Windows.Forms.Button();
            this.AddStudBtn = new System.Windows.Forms.Button();
            this.ChangeTimingBtn = new System.Windows.Forms.Button();
            this.ChangeGroupBtn = new System.Windows.Forms.Button();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.AdminGradBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChangeTimingBtn);
            this.panel1.Controls.Add(this.ChangeGroupBtn);
            this.panel1.Controls.Add(this.MarkBtn);
            this.panel1.Controls.Add(this.AdminGradBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 120);
            this.panel1.TabIndex = 1;
            // 
            // AddLbl
            // 
            this.AddLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLbl.AutoSize = true;
            this.AddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddLbl.Location = new System.Drawing.Point(143, 199);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(213, 25);
            this.AddLbl.TabIndex = 4;
            this.AddLbl.Text = "Добавить студента";
            // 
            // DeleteLbl
            // 
            this.DeleteLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteLbl.AutoSize = true;
            this.DeleteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteLbl.Location = new System.Drawing.Point(425, 199);
            this.DeleteLbl.Name = "DeleteLbl";
            this.DeleteLbl.Size = new System.Drawing.Size(226, 25);
            this.DeleteLbl.TabIndex = 5;
            this.DeleteLbl.Text = "Отчислить студента";
            // 
            // DeleteStudBtn
            // 
            this.DeleteStudBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteStudBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.Del;
            this.DeleteStudBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteStudBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteStudBtn.FlatAppearance.BorderSize = 4;
            this.DeleteStudBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudBtn.Location = new System.Drawing.Point(451, 240);
            this.DeleteStudBtn.Name = "DeleteStudBtn";
            this.DeleteStudBtn.Size = new System.Drawing.Size(161, 137);
            this.DeleteStudBtn.TabIndex = 3;
            this.DeleteStudBtn.UseVisualStyleBackColor = true;
            this.DeleteStudBtn.Click += new System.EventHandler(this.DeleteStudBtn_Click);
            // 
            // AddStudBtn
            // 
            this.AddStudBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStudBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.Add;
            this.AddStudBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddStudBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddStudBtn.FlatAppearance.BorderSize = 4;
            this.AddStudBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudBtn.Location = new System.Drawing.Point(170, 240);
            this.AddStudBtn.Name = "AddStudBtn";
            this.AddStudBtn.Size = new System.Drawing.Size(159, 137);
            this.AddStudBtn.TabIndex = 2;
            this.AddStudBtn.UseVisualStyleBackColor = true;
            this.AddStudBtn.Click += new System.EventHandler(this.AddStudBtn_Click);
            // 
            // ChangeTimingBtn
            // 
            this.ChangeTimingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeTimingBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeTimingBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.schedule;
            this.ChangeTimingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeTimingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeTimingBtn.FlatAppearance.BorderSize = 0;
            this.ChangeTimingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeTimingBtn.Location = new System.Drawing.Point(656, 3);
            this.ChangeTimingBtn.Name = "ChangeTimingBtn";
            this.ChangeTimingBtn.Size = new System.Drawing.Size(131, 116);
            this.ChangeTimingBtn.TabIndex = 10;
            this.ChangeTimingBtn.UseVisualStyleBackColor = false;
            this.ChangeTimingBtn.Click += new System.EventHandler(this.ChangeTimingBtn_Click);
            // 
            // ChangeGroupBtn
            // 
            this.ChangeGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeGroupBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.group;
            this.ChangeGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeGroupBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeGroupBtn.FlatAppearance.BorderSize = 0;
            this.ChangeGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeGroupBtn.Location = new System.Drawing.Point(420, -1);
            this.ChangeGroupBtn.Name = "ChangeGroupBtn";
            this.ChangeGroupBtn.Size = new System.Drawing.Size(130, 120);
            this.ChangeGroupBtn.TabIndex = 9;
            this.ChangeGroupBtn.UseVisualStyleBackColor = false;
            // 
            // MarkBtn
            // 
            this.MarkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkBtn.BackColor = System.Drawing.Color.White;
            this.MarkBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.report_card;
            this.MarkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MarkBtn.FlatAppearance.BorderSize = 0;
            this.MarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkBtn.Location = new System.Drawing.Point(204, -1);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(124, 120);
            this.MarkBtn.TabIndex = 8;
            this.MarkBtn.UseVisualStyleBackColor = false;
            this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
            // 
            // AdminGradBtn
            // 
            this.AdminGradBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminGradBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.graduate2;
            this.AdminGradBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminGradBtn.FlatAppearance.BorderSize = 0;
            this.AdminGradBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminGradBtn.Location = new System.Drawing.Point(11, 1);
            this.AdminGradBtn.Name = "AdminGradBtn";
            this.AdminGradBtn.Size = new System.Drawing.Size(125, 118);
            this.AdminGradBtn.TabIndex = 7;
            this.AdminGradBtn.UseVisualStyleBackColor = false;
            this.AdminGradBtn.Click += new System.EventHandler(this.AdminGradBtn_Click);
            // 
            // ChangeGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteLbl);
            this.Controls.Add(this.AddLbl);
            this.Controls.Add(this.DeleteStudBtn);
            this.Controls.Add(this.AddStudBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeGroupForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeTimingBtn;
        private System.Windows.Forms.Button ChangeGroupBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button AdminGradBtn;
        private System.Windows.Forms.Button AddStudBtn;
        private System.Windows.Forms.Button DeleteStudBtn;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.Label DeleteLbl;
    }
}