using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class ChangeGroupForm : Form
    {
        public ChangeGroupForm()
        {
            InitializeComponent();
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            GiveMarkForm giveMarkForm = new GiveMarkForm();
            giveMarkForm.Show();
        }

        private void ChangeTimingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeTimingForm timingForm = new ChangeTimingForm();
            timingForm.Show();
        }

        private void AdminGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminFuncForm adminFForm = new AdminFuncForm();
            adminFForm.Show();
        }

        private void AddStudBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStudForm add = new AddStudForm();
            add.Show();
        }

        private void DeleteStudBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteStudForm del = new DeleteStudForm();
            del.Show();
        }
    }
}
