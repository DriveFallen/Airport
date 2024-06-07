using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airport.Редактирование
{
    public partial class Form_Airports_Routes_Flights : Form
    {
        public SqlConnection connection;

        public Form_Airports_Routes_Flights()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public void UpdateInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Routes". При необходимости она может быть перемещена или удалена.
            this.routesTableAdapter.Fill(this.airportDataSet.Routes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);

            comboBox_route_airport.Items.Clear();
            comboBox_flight_id_route.Items.Clear();

            foreach (DataGridViewRow row in dataGridView_airports.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_route_airport.Items.Add(cellValue);
                }
            }

            foreach (DataGridViewRow row in dataGridView_routes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_flight_id_route.Items.Add(cellValue);
                }
            }
        }

        private void Form_Airports_Routes_Flights_Load(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void button_add_airport_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Airports WHERE Name = @name";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_name = new SqlParameter("@name", textBox_airports_name.Text);

            string Add = "INSERT INTO Airports VALUES (@name, @city)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter name = new SqlParameter("@name", textBox_airports_name.Text);
            SqlParameter city = new SqlParameter("@city", textBox_airports_city.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_name);
                Add_query.Parameters.Add(name);
                Add_query.Parameters.Add(city);

                if (textBox_airports_name.Text != null || textBox_airports_city.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Аэропорт добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт с таким названием уже есть в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_change_airport_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Airports WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@id", textBox_airports_id.Text);

            string Change = "UPDATE Airports SET Name = @name, City = @city WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter ID = new SqlParameter("@id", textBox_airports_id.Text);
            SqlParameter name = new SqlParameter("@name", textBox_airports_name.Text);
            SqlParameter city = new SqlParameter("@city", textBox_airports_city.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Change_query.Parameters.Add(ID);
                Change_query.Parameters.Add(name);
                Change_query.Parameters.Add(city);

                if (textBox_airports_id.Text != null || textBox_airports_name.Text != null || textBox_airports_city.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные аэропорта изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт с таким ID не найден", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_delete_airport_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Airports WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@id", textBox_airports_id.Text);

            string Delete = "DELETE FROM Airports WHERE ID = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_airports_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Delete_query.Parameters.Add(id);

                if (textBox_airports_id.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Аэропорт удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт с таким ID не найден", "Ошибка!");
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
                UpdateInformation();
            }
        }

        private void button_route_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Routes WHERE ID_Airport = (SELECT ID FROM Airports WHERE Name = @airport)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_airport = new SqlParameter("@airport", comboBox_route_airport.Text);

            string Add = "INSERT INTO Routes VALUES ((SELECT ID FROM Airports WHERE Name = @airport), @check)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter airport = new SqlParameter("@airport", comboBox_route_airport.Text);
            SqlParameter check = new SqlParameter("@check", checkBox_route.Checked);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_airport);
                Add_query.Parameters.Add(airport);
                Add_query.Parameters.Add(check);

                if (comboBox_route_airport.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Маршрут добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Маршрут в этот город уже есть в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_route_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Routes WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_route_id.Text);

            string Change = "UPDATE Routes SET ID_Airport = (SELECT ID FROM Airports WHERE Name = @airport), Direction = @check WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_route_id.Text);
            SqlParameter airport = new SqlParameter("@airport", comboBox_route_airport.Text);
            SqlParameter check = new SqlParameter("@check", checkBox_route.Checked);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(airport);
                Change_query.Parameters.Add(check);

                if (textBox_route_id.Text != null || comboBox_route_airport.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные маршрута изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Маршрут с таким ID не найден в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_route_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Routes WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_route_id.Text);

            string Delete = "DELETE FROM Routes WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_route_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);

                if (textBox_route_id.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Маршрут удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Маршрут с таким ID не найден в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }

        private void button_flights_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Flights WHERE ID_Route = @route and DepartureTime = @departure and ArrivalTime = @arrival and Weekday = @weekday";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_route = new SqlParameter("@route", comboBox_flight_id_route.Text);
            SqlParameter proverka_departure = new SqlParameter("@departure", dateTimePicker_flight_departure.Value);
            SqlParameter proverka_arrival = new SqlParameter("@arrival", dateTimePicker_flight_arrival.Value);
            SqlParameter proverka_weekday = new SqlParameter("@weekday", comboBox_flights_weekdays.Text);

            string Add = "INSERT INTO Flights VALUES (@route, @departure, @arrival, @weekday)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter route = new SqlParameter("@route", comboBox_flight_id_route.Text);
            SqlParameter departure = new SqlParameter("@departure", dateTimePicker_flight_departure.Value);
            SqlParameter arrival = new SqlParameter("@arrival", dateTimePicker_flight_arrival.Value);
            SqlParameter weekday = new SqlParameter("@weekday", comboBox_flights_weekdays.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_route);
                Proverka_query.Parameters.Add(proverka_departure);
                Proverka_query.Parameters.Add(proverka_arrival);
                Proverka_query.Parameters.Add(proverka_weekday);
                Add_query.Parameters.Add(route);
                Add_query.Parameters.Add(departure);
                Add_query.Parameters.Add(arrival);
                Add_query.Parameters.Add(weekday);

                if (comboBox_route_airport.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Полёт добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Полёт с этими данными уже есть в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_flights_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Flights WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_route = new SqlParameter("@id", textBox_flight_id.Text);

            string Change = "UPDATE Flights SET ID_Route = @route, DepartureTime = @departure, ArrivalTime = @arrival, Weekday = @weekday WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_flight_id.Text);
            SqlParameter route = new SqlParameter("@route", comboBox_flight_id_route.Text);
            SqlParameter departure = new SqlParameter("@departure", dateTimePicker_flight_departure.Value);
            SqlParameter arrival = new SqlParameter("@arrival", dateTimePicker_flight_arrival.Value);
            SqlParameter weekday = new SqlParameter("@weekday", comboBox_flights_weekdays.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_route);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(route);
                Change_query.Parameters.Add(departure);
                Change_query.Parameters.Add(arrival);
                Change_query.Parameters.Add(weekday);

                if (textBox_route_id.Text != null || comboBox_flight_id_route.Text != null || comboBox_flights_weekdays.Text != null ) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные полёта изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Полёт с таким ID не найден в базе", "Ошибка!");
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
                UpdateInformation();
            }
        }
        private void button_flights_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Flights WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_flight_id.Text);

            string Delete = "DELETE FROM Flights WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_flight_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);

                if (textBox_route_id.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Полёт удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Полёт с таким ID не найден в базе", "Ошибка!");
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
                UpdateInformation();
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
