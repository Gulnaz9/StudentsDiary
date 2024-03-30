using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            this.AdminPassTextBox.AutoSize = false;
            this.AdminPassTextBox.Size = new Size(this.AdminPassTextBox.Size.Width, 34);
        }

        private void AdminEnterBtn_Click(object sender, EventArgs e)
        {
            string loginUser = AdminLogTextBox.Text;
            string passUser = AdminPassTextBox.Text;

            try
            {

                DB db = new DB();

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `login` = @lU AND `password` = @pU", db.GetConnection());
                command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    AdminFuncForm func = new AdminFuncForm();
                    func.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
