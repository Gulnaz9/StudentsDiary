using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AccForm accForm = new AccForm();
            accForm.Show();
        }

        private void GradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void TimingBtn_Click(object sender, EventArgs e)
        { 
            TimingForm form = new TimingForm();
            form.Show();
        }
    }
}
