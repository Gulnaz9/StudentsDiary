using System;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class DeleteStudForm : Form
    {
        public DeleteStudForm()
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
