using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AccForm : Form
    {
        public AccForm()
        {
            InitializeComponent();
        }

        private void AccGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void GradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MarkForm markForm = new MarkForm();
            markForm.Show();
        }

        private void TimingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TimingForm timingForm = new TimingForm();
            timingForm.Show();
        }
    }
}
