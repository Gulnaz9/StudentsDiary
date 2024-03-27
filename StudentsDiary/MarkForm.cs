using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent();
        }

        private void GradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void TimingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TimingForm timingForm = new TimingForm();
            timingForm.Show();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AccForm accForm = new AccForm();
            accForm.Show();
        }
    }
}
