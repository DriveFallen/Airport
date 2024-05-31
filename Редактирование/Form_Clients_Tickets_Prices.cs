using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.Редактирование
{
    public partial class Form_Clients : Form
    {
        public SqlConnection connection;

        public Form_Clients()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.airportDataSet.Clients);
        }
        
        private void Form_Clients_Tickets_Prices_Load(object sender, EventArgs e)
        {
            UpdateWindowInformation();
        }

        private void button_add_client_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Clients WHERE Passport = @passport";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_passport = new SqlParameter("@passport", textBox_idPassport_client.Text);

            string Add = "INSERT INTO Clients VALUES (@name, @surname, @passport)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter name = new SqlParameter("@name", textBox_name_client.Text);
            SqlParameter surname = new SqlParameter("@surname", textBox_surname_client.Text);
            SqlParameter passport = new SqlParameter("@passport", textBox_idPassport_client.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_passport);
                Add_query.Parameters.Add(name);
                Add_query.Parameters.Add(surname);
                Add_query.Parameters.Add(passport);

                if (textBox_name_client.Text != null || textBox_surname_client.Text != null || textBox_idPassport_client.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Клиент добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Клиент с этим номером паспорта уже есть в базе", "Ошибка!");
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
        private void button_change_client_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Clients WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@id", textBox_ID_client.Text);

            string Change = "UPDATE Clients SET Name = @name, Surname = @surname, Passport = @passport WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter ID = new SqlParameter("@id", textBox_ID_client.Text);
            SqlParameter name = new SqlParameter("@name", textBox_name_client.Text);
            SqlParameter surname = new SqlParameter("@surname", textBox_surname_client.Text);
            SqlParameter passport = new SqlParameter("@passport", textBox_idPassport_client.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Change_query.Parameters.Add(ID);
                Change_query.Parameters.Add(name);
                Change_query.Parameters.Add(surname);
                Change_query.Parameters.Add(passport);

                if (textBox_ID_client.Text != null || textBox_name_client.Text != null || textBox_surname_client.Text != null || textBox_idPassport_client.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные клиента изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Клиент с таким ID не найден", "Ошибка!");
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
        private void button_delete_client_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Clients WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@id", textBox_ID_client.Text);

            string Delete = "DELETE FROM Clients WHERE IВ = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_ID_client.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Delete_query.Parameters.Add(id);

                if (textBox_ID_client.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Клиент удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Клиент с таким ID не найден", "Ошибка!");
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
    }
}
