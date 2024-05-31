using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airport.Редактирование
{
    public partial class Form_Users : Form
    {
        public SqlConnection connection;

        public Form_Users()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.airportDataSet.Users);
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            UpdateWindowInformation();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Users WHERE Login = @login";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_login = new SqlParameter("@login", textBox_login.Text);

            string Add = "INSERT INTO Users VALUES (@login, @password, HASHBYTES('SHA2_512', @password), @Role)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter login = new SqlParameter("@login", textBox_login.Text);
            SqlParameter password = new SqlParameter("@password", textBox_password.Text);
            SqlParameter role = new SqlParameter("@role", textBox_role.Text);


            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_login);
                Add_query.Parameters.Add(login);
                Add_query.Parameters.Add(password);
                Add_query.Parameters.Add(role);

                if (textBox_login.Text != null || textBox_password.Text != null || textBox_role.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Пользователь добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Логин уже занят", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Users WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_ID.Text);

            string Change = "UPDATE Users SET Login = @login, Password = @password, HashPassword = HASHBYTES('SHA2_512', @password), Role = @role WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_ID.Text);
            SqlParameter login = new SqlParameter("@login", textBox_login.Text);
            SqlParameter password = new SqlParameter("@password", textBox_password.Text);
            SqlParameter role = new SqlParameter("@role", textBox_role.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(login);
                Change_query.Parameters.Add(password);
                Change_query.Parameters.Add(role);

                if (textBox_ID.Text != null || textBox_login.Text != null || textBox_password.Text != null || textBox_role.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные пользователя изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким ID не найден", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Users WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_ID.Text);

            string Delete = "DELETE FROM Users WHERE ID = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_ID.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_query.Parameters.Add(id);

                if (textBox_ID.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Пользователь удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким ID не найден", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form = new Form_Admin();
            form.Show();
            this.Close();
        }
    }
}
