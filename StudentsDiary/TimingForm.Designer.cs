namespace StudentsDiary
{
    partial class TimingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimingForm));
            this.ChooseTextBox = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewLessonCard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.ChangeTimingBtn = new System.Windows.Forms.Button();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.GradBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseTextBox
            // 
            this.ChooseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChooseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseTextBox.Location = new System.Drawing.Point(0, 126);
            this.ChooseTextBox.Multiline = true;
            this.ChooseTextBox.Name = "ChooseTextBox";
            this.ChooseTextBox.ReadOnly = true;
            this.ChooseTextBox.Size = new System.Drawing.Size(800, 32);
            this.ChooseTextBox.TabIndex = 10;
            this.ChooseTextBox.Text = "Ниже выберите необходимый день недели";
            // 
            // cmbDays
            // 
            this.cmbDays.AllowDrop = true;
            this.cmbDays.BackColor = System.Drawing.Color.White;
            this.cmbDays.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(0, 155);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(800, 28);
            this.cmbDays.TabIndex = 11;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeColumns = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Subject,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSchedule.Location = new System.Drawing.Point(0, 180);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSchedule.Name = "dgvSchedule";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSchedule.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvSchedule.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSchedule.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvSchedule.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSchedule.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvSchedule.RowTemplate.Height = 34;
            this.dgvSchedule.Size = new System.Drawing.Size(800, 270);
            this.dgvSchedule.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Дисциплина";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кабинет";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Преподаватель";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnViewLessonCard
            // 
            this.btnViewLessonCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnViewLessonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewLessonCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewLessonCard.Location = new System.Drawing.Point(0, 410);
            this.btnViewLessonCard.Name = "btnViewLessonCard";
            this.btnViewLessonCard.Size = new System.Drawing.Size(800, 40);
            this.btnViewLessonCard.TabIndex = 13;
            this.btnViewLessonCard.Text = "Посмотреть карточку занятия";
            this.btnViewLessonCard.UseVisualStyleBackColor = false;
            this.btnViewLessonCard.Click += new System.EventHandler(this.BtnViewLessonCard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AccountBtn);
            this.panel1.Controls.Add(this.ChangeTimingBtn);
            this.panel1.Controls.Add(this.MarkBtn);
            this.panel1.Controls.Add(this.GradBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 14;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.user__1_;
            this.AccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AccountBtn.FlatAppearance.BorderSize = 0;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Location = new System.Drawing.Point(209, 6);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(131, 113);
            this.AccountBtn.TabIndex = 11;
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // ChangeTimingBtn
            // 
            this.ChangeTimingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeTimingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeTimingBtn.BackgroundImage = global::StudentsDiary.Properties.Resources.schedule;
            this.ChangeTimingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeTimingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeTimingBtn.FlatAppearance.BorderSize = 0;
            this.ChangeTimingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeTimingBtn.Location = new System.Drawing.Point(424, 4);
            this.ChangeTimingBtn.Name = "ChangeTimingBtn";
            this.ChangeTimingBtn.Size = new System.Drawing.Size(131, 116);
            this.ChangeTimingBtn.TabIndex = 10;
            this.ChangeTimingBtn.UseVisualStyleBackColor = false;
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
            this.MarkBtn.Location = new System.Drawing.Point(629, 3);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(124, 120);
            this.MarkBtn.TabIndex = 8;
            this.MarkBtn.UseVisualStyleBackColor = false;
            this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
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
            // TimingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewLessonCard);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.ChooseTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChooseTextBox;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnViewLessonCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeTimingBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button GradBtn;
        private System.Windows.Forms.Button AccountBtn;
    }
}