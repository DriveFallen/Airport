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
    public partial class Form_Clients_Tickets_Prices : Form
    {
        public SqlConnection connection;

        public Form_Clients_Tickets_Prices()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.airportDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Prices". При необходимости она может быть перемещена или удалена.
            this.pricesTableAdapter.Fill(this.airportDataSet.Prices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.airportDataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Departures". При необходимости она может быть перемещена или удалена.
            this.departuresTableAdapter.Fill(this.airportDataSet.Departures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.airportDataSet.Classes);

            comboBox_ticket_price.Items.Clear();
            comboBox_ticket_client.Items.Clear();
            comboBox_price_class.Items.Clear();
            comboBox_price_departure.Items.Clear();
            
            foreach (DataGridViewRow row in dataGridView_prices.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_ticket_client.Items.Add(cellValue);
                }
            }
            foreach (DataGridViewRow row in dataGridView_clients.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_ticket_client.Items.Add(cellValue);
                }
            }
            foreach (DataGridViewRow row in dataGridView_classes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_price_class.Items.Add(cellValue);
                }
            }
            foreach (DataGridViewRow row in dataGridView_departures.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_price_departure.Items.Add(cellValue);
                }
            }
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

        private void button_ticket_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Tickets WHERE ID_Price = @price and ID_Client = @client and Seat = @seat";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_price = new SqlParameter("@price", comboBox_ticket_price.Text);
            SqlParameter proverka_client = new SqlParameter("@client", comboBox_ticket_client.Text);
            SqlParameter proverka_seat = new SqlParameter("@seat", textBox_ticket_seat.Text);

            string Add = "INSERT INTO Tickets VALUES (@price, @client, @seat, @newPrice)";
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter price = new SqlParameter("@price", comboBox_ticket_price.Text);
            SqlParameter client = new SqlParameter("@client", comboBox_ticket_client.Text);
            SqlParameter seat = new SqlParameter("@seat", textBox_ticket_seat.Text);
            SqlParameter newPrice = new SqlParameter("@newPrice", textBox_ticket_price.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_price);
                Proverka_query.Parameters.Add(proverka_client);
                Proverka_query.Parameters.Add(proverka_seat);
                Add_query.Parameters.Add(price);
                Add_query.Parameters.Add(client);
                Add_query.Parameters.Add(seat);
                Add_query.Parameters.Add(newPrice);

                if (comboBox_ticket_price.Text != null || comboBox_ticket_client.Text != null || textBox_ticket_seat != null || textBox_ticket_price.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Билет добавлен!", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Билет с таким ценником, клиентом и местом уже существует!", "Ошибка!");
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
        private void button_ticket_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Tickets WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_ticket_id.Text);

            string Change = "UPDATE Tickets SET ID_Price = @price, ID_Client = @client, Seat = @seat, NewPrice = @newPrice WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_ticket_id.Text);
            SqlParameter price = new SqlParameter("@price", comboBox_ticket_price.Text);
            SqlParameter client = new SqlParameter("@client", comboBox_ticket_client.Text);
            SqlParameter seat = new SqlParameter("@seat", textBox_ticket_seat.Text);
            SqlParameter newPrice = new SqlParameter("@newPrice", textBox_ticket_price.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(price);
                Change_query.Parameters.Add(client);
                Change_query.Parameters.Add(seat);
                Change_query.Parameters.Add(newPrice);

                if (textBox_ticket_id.Text != null || comboBox_ticket_price.Text != null || comboBox_ticket_client.Text != null || textBox_ticket_seat.Text != null || textBox_ticket_seat.Text != null || textBox_ticket_price.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) > 0)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные билета изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Билета с таким ID не найдено!", "Ошибка!");
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
        private void button_ticket_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Tickets WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_ticket_id.Text);

            string Delete = "DELETE FROM Tickets WHERE ID = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_ticket_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_query.Parameters.Add(id);

                if (textBox_ticket_id.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) > 0)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Билет удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Билета с таким ID не найдено!", "Ошибка!");
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

        private void button_price_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Prices WHERE ID_Class = (SELECT ID_Class WHERE Name = @class) and ID_Departure = @departure";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_price_class.Text);
            SqlParameter proverka_departure = new SqlParameter("@departure", comboBox_price_departure.Text);

            string Add = "INSERT INTO Prices VALUES (SELECT ID_Class FROM Classes WHERE Name = @class), @departure, @price"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter className = new SqlParameter("@class", comboBox_price_class.Text);
            SqlParameter departure = new SqlParameter("@departure", comboBox_price_departure.Text);
            SqlParameter price = new SqlParameter("@price", textBox_price_price.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_class);
                Proverka_query.Parameters.Add(proverka_departure);
                Add_query.Parameters.Add(className);
                Add_query.Parameters.Add(departure);
                Add_query.Parameters.Add(price);

                if (comboBox_price_class.Text != null || comboBox_price_departure.Text != null || textBox_price_price.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Цена на класс и отправление добавлена", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Цена на это сочетание класса и отправления уже есть в базе", "Ошибка!");
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
        private void button_price_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Prices WHERE ID_Class = (SELECT ID_Class WHERE Name = @class) and ID_Departure = @departure and ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_price_id.Text);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_price_class.Text);
            SqlParameter proverka_departure = new SqlParameter("@departure", comboBox_price_departure.Text);

            string Change = "UPDATE Prices SET Price = @price WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_price_id.Text);
            SqlParameter price = new SqlParameter("@price", textBox_price_price.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Proverka_query.Parameters.Add(proverka_class);
                Proverka_query.Parameters.Add(proverka_departure);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(price);

                if (textBox_price_id.Text != null || comboBox_price_class.Text != null || comboBox_price_departure.Text != null || textBox_price_price.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные ценника изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Цена с таким ID, сочетанием класса и отправления не найдена в базе", "Ошибка!");
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
        private void button_price_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Prices WHERE ID_Class = (SELECT ID_Class WHERE Name = @class) and ID_Departure = @departure and ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_price_id.Text);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_price_class.Text);
            SqlParameter proverka_departure = new SqlParameter("@departure", comboBox_price_departure.Text);

            string Change = "DELETE FROM Prices WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_price_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Proverka_query.Parameters.Add(proverka_class);
                Proverka_query.Parameters.Add(proverka_departure);
                Change_query.Parameters.Add(id);

                if (textBox_price_id.Text != null || comboBox_price_class.Text != null || comboBox_price_departure.Text != null || textBox_price_price.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Ценник удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Цена с таким ID, сочетанием класса и отправления не найдена в базе", "Ошибка!");
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
