using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class GiveMarkForm : Form
    {
        public GiveMarkForm()
        {
            InitializeComponent();
        }

        private void AdminGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminFuncForm form = new AdminFuncForm();
            form.Show();
        }

        private void ChangeGroupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeGroupForm groupForm = new ChangeGroupForm();
            groupForm.Show();
        }

        private void ChangeTimingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeTimingForm form = new ChangeTimingForm();
            form.Show();
        }
    }
}
