namespace StudentsDiary
{
    partial class MarkForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.TimingBtn = new System.Windows.Forms.Button();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.GradBtn = new System.Windows.Forms.Button();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AccountBtn);
            this.panel1.Controls.Add(this.TimingBtn);
            this.panel1.Controls.Add(this.MarkBtn);
            this.panel1.Controls.Add(this.GradBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 15;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountBtn.BackColor = System.Drawing.Color.White;
            this.AccountBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.user__1_;
            this.AccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AccountBtn.FlatAppearance.BorderSize = 0;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Location = new System.Drawing.Point(204, 6);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(131, 113);
            this.AccountBtn.TabIndex = 11;
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // TimingBtn
            // 
            this.TimingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimingBtn.BackColor = System.Drawing.Color.White;
            this.TimingBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.schedule;
            this.TimingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TimingBtn.FlatAppearance.BorderSize = 0;
            this.TimingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimingBtn.Location = new System.Drawing.Point(424, 4);
            this.TimingBtn.Name = "TimingBtn";
            this.TimingBtn.Size = new System.Drawing.Size(131, 116);
            this.TimingBtn.TabIndex = 10;
            this.TimingBtn.UseVisualStyleBackColor = false;
            this.TimingBtn.Click += new System.EventHandler(this.TimingBtn_Click);
            // 
            // MarkBtn
            // 
            this.MarkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MarkBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.report_card;
            this.MarkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MarkBtn.FlatAppearance.BorderSize = 0;
            this.MarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkBtn.Location = new System.Drawing.Point(629, 3);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(124, 120);
            this.MarkBtn.TabIndex = 8;
            this.MarkBtn.UseVisualStyleBackColor = false;
            // 
            // GradBtn
            // 
            this.GradBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GradBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.graduate2;
            this.GradBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GradBtn.FlatAppearance.BorderSize = 0;
            this.GradBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradBtn.Location = new System.Drawing.Point(11, 1);
            this.GradBtn.Name = "GradBtn";
            this.GradBtn.Size = new System.Drawing.Size(125, 118);
            this.GradBtn.TabIndex = 7;
            this.GradBtn.UseVisualStyleBackColor = false;
            this.GradBtn.Click += new System.EventHandler(this.GradBtn_Click);
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkTextBox.Location = new System.Drawing.Point(0, 133);
            this.MarkTextBox.Multiline = true;
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.ReadOnly = true;
            this.MarkTextBox.Size = new System.Drawing.Size(800, 32);
            this.MarkTextBox.TabIndex = 16;
            this.MarkTextBox.Text = "Электронная зачётная книжка";
            this.MarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button TimingBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button GradBtn;
        private System.Windows.Forms.TextBox MarkTextBox;
    }
}