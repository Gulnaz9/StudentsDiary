using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class ChangeTimingForm : Form
    {
        public ChangeTimingForm()
        {
            InitializeComponent();
        }

        private void AdminGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminFuncForm adminForm = new AdminFuncForm();
            adminForm.Show();
        }

        private void ChangeGroupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeGroupForm changeGroupForm = new ChangeGroupForm();
            changeGroupForm.Show();
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            GiveMarkForm giveMarkForm = new GiveMarkForm();
            giveMarkForm.Show();
        }
    }
}
