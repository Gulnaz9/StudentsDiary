using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AdminFuncForm : Form
    {
        public AdminFuncForm()
        {
            InitializeComponent();
        }

        private void AdminGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
        private void MarkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiveMarkForm giveMarkForm = new GiveMarkForm();
            giveMarkForm.Show();
        }
        private void ChangeGroupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeGroupForm changeGroupForm = new ChangeGroupForm();
            changeGroupForm.Show();
        }
        private void ChangeTimingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeTimingForm form = new ChangeTimingForm();
            form.Show();
        }
    }
}
