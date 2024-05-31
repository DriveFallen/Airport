using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form_Login : Form
    {
        public SqlConnection connection;

        public Form_Login()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            string Query = "Select count(*) from Users where Login = @login";
            SqlCommand Select_Login = new SqlCommand(Query, connection);
            SqlParameter parametr_login = new SqlParameter("@login", textBox_login.Text);
            Select_Login.Parameters.Add(parametr_login);

            string Query_2 = "Select count(*) from Users where Login = @login and Password = @password";
            SqlCommand Select_Log_Pass = new SqlCommand(Query_2, connection);
            SqlParameter parametr_login_2 = new SqlParameter("@login", textBox_login.Text);
            SqlParameter parametr_password_2 = new SqlParameter("@password", textBox_password.Text);
            Select_Log_Pass.Parameters.Add(parametr_login_2);
            Select_Log_Pass.Parameters.Add(parametr_password_2);

            string Query_3 = "Select count(*) from Users where Login = @login and Password = @password and Role = 'Admin'";
            SqlCommand Select_Login_Pass_Adm = new SqlCommand(Query_3, connection);
            SqlParameter parametr_login_3 = new SqlParameter("@login", textBox_login.Text);
            SqlParameter parametr_password_3 = new SqlParameter("@password", textBox_password.Text);
            Select_Login_Pass_Adm.Parameters.Add(parametr_login_3);
            Select_Login_Pass_Adm.Parameters.Add(parametr_password_3);

            try
            {
                connection.Open();

                if (Convert.ToInt32(Select_Login.ExecuteScalar()) >= 1)
                {
                    if (Convert.ToInt32(Select_Log_Pass.ExecuteScalar()) == 1)
                    {
                        if (Convert.ToInt32(Select_Login_Pass_Adm.ExecuteScalar()) == 1)
                        {
                            Form_Admin form_admin = new Form_Admin();
                            form_admin.Show();
                            MessageBox.Show("Авторизация под Администратором успешной пройдена, \n добро пожаловать на сервер ШиЗоФрЕнИя!", "Авторизация");
                            this.Hide();
                        }
                        else
                        {
                            Form_Main form_main = new Form_Main();
                            form_main.Show();
                            MessageBox.Show("Авторизация в режиме просмотра успешной пройдена, \n добро пожаловать на сервер ШиЗоФрЕнИя!", "Авторизация");
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль, \n Попробуйте снова!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь не обнаружен, \n Попробуйте снова!", "Ошибка!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "пиздец");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
