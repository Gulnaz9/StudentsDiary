using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PasswordTextBox.AutoSize = false;
            this.PasswordTextBox.Size = new Size(this.PasswordTextBox.Size.Width, 34);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string loginUser = LoginTextBox.Text;
            string passUser = PasswordTextBox.Text;

            try
            {
                DB db = new DB();

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lU AND `password` = @pU", db.GetConnection());
                command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
