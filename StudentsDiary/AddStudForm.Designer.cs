namespace StudentsDiary
{
    partial class AddStudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChooseTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SurTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.PatTxtBox = new System.Windows.Forms.TextBox();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.SurLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PatLbl = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 2;
            // 
            // ChooseTextBox
            // 
            this.ChooseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChooseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseTextBox.Location = new System.Drawing.Point(0, 116);
            this.ChooseTextBox.Multiline = true;
            this.ChooseTextBox.Name = "ChooseTextBox";
            this.ChooseTextBox.ReadOnly = true;
            this.ChooseTextBox.Size = new System.Drawing.Size(800, 32);
            this.ChooseTextBox.TabIndex = 12;
            this.ChooseTextBox.Text = "Добавить студента";
            this.ChooseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(372, 206);
            this.NumberTextBox.Multiline = true;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(289, 32);
            this.NumberTextBox.TabIndex = 14;
            // 
            // SurTxtBox
            // 
            this.SurTxtBox.Location = new System.Drawing.Point(372, 252);
            this.SurTxtBox.Multiline = true;
            this.SurTxtBox.Name = "SurTxtBox";
            this.SurTxtBox.Size = new System.Drawing.Size(289, 32);
            this.SurTxtBox.TabIndex = 15;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(372, 290);
            this.NameTxtBox.Multiline = true;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(289, 32);
            this.NameTxtBox.TabIndex = 16;
            // 
            // PatTxtBox
            // 
            this.PatTxtBox.Location = new System.Drawing.Point(372, 328);
            this.PatTxtBox.Multiline = true;
            this.PatTxtBox.Name = "PatTxtBox";
            this.PatTxtBox.Size = new System.Drawing.Size(289, 32);
            this.PatTxtBox.TabIndex = 17;
            // 
            // NumberLbl
            // 
            this.NumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NumberLbl.Location = new System.Drawing.Point(167, 206);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(162, 32);
            this.NumberLbl.TabIndex = 18;
            this.NumberLbl.Text = "Номер группы";
            // 
            // SurLbl
            // 
            this.SurLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SurLbl.Location = new System.Drawing.Point(167, 252);
            this.SurLbl.Name = "SurLbl";
            this.SurLbl.Size = new System.Drawing.Size(162, 32);
            this.SurLbl.TabIndex = 19;
            this.SurLbl.Text = "Фамилия";
            // 
            // NameLbl
            // 
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameLbl.Location = new System.Drawing.Point(167, 290);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(162, 32);
            this.NameLbl.TabIndex = 20;
            this.NameLbl.Text = "Имя";
            // 
            // PatLbl
            // 
            this.PatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PatLbl.Location = new System.Drawing.Point(167, 328);
            this.PatLbl.Name = "PatLbl";
            this.PatLbl.Size = new System.Drawing.Size(162, 32);
            this.PatLbl.TabIndex = 21;
            this.PatLbl.Text = "Отчество";
            // 
            // ChangeTimingBtn
            // 
            this.ChangeTimingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeTimingBtn.BackColor = System.Drawing.Color.Gainsboro;
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
            this.MarkBtn.BackColor = System.Drawing.Color.Gainsboro;
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
            // AddStudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SurLbl);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.PatTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.SurTxtBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ChooseTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudForm";
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
        private System.Windows.Forms.TextBox ChooseTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox SurTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox PatTxtBox;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label SurLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label PatLbl;
    }
}