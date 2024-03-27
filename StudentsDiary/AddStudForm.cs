using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddStudForm : Form
    {
        public AddStudForm()
        {
            InitializeComponent();
        }

        private void AdminGradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeGroupForm changeGroupForm = new ChangeGroupForm();
            changeGroupForm.Show();
        }
    }
}
