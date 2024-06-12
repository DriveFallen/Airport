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
    public partial class Form_Departures_Pilots : Form
    {
        public SqlConnection connection;

        public Form_Departures_Pilots()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Pilots". При необходимости она может быть перемещена или удалена.
            this.pilotsTableAdapter.Fill(this.airportDataSet.Pilots);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Departures". При необходимости она может быть перемещена или удалена.
            this.departuresTableAdapter.Fill(this.airportDataSet.Departures);

            comboBox_departures_aircraft.Items.Clear();
            comboBox_departures_flight.Items.Clear();
            comboBox_departures_pilot.Items.Clear();

            SqlCommand cmd_aircrafts = new SqlCommand("SELECT * FROM Aircrafts", connection);
            SqlDataAdapter da_aircrafts = new SqlDataAdapter(cmd_aircrafts);
            DataTable dt_aircrafts = new DataTable();
            da_aircrafts.Fill(dt_aircrafts);
            dataGridView_departures_aircrafts.DataSource = dt_aircrafts;   

            SqlCommand cmd_flights = new SqlCommand("SELECT * FROM Flights", connection);
            SqlDataAdapter da_flights = new SqlDataAdapter(cmd_flights);
            DataTable dt_flights = new DataTable();
            da_flights.Fill(dt_flights);
            dataGridView_departures_flights.DataSource = dt_flights;         

            foreach (DataGridViewRow row in dataGridView_departures_aircrafts.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_departures_aircraft.Items.Add(cellValue);
                }
            }

            foreach (DataGridViewRow row in dataGridView_departures_flights.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    comboBox_departures_flight.Items.Add(row.Cells[0].Value.ToString());
                }
            }

            foreach (DataGridViewRow row in dataGridView_pilots.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    comboBox_departures_pilot.Items.Add(row.Cells[2].Value.ToString());
                }
            }
        }

        private void Form_Departures_Pilots_Load(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void button_departures_add_Click(object sender, EventArgs e)
        {

        }
        private void button_departures_change_Click(object sender, EventArgs e)
        {

        }
        private void button_departures_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_pilots_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Pilots WHERE Name = @name and Surname = @surname";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_name = new SqlParameter("@name", textBox_pilots_name.Text);
            SqlParameter proverka_surname = new SqlParameter("@surname", textBox_pilots_surname.Text);

            string Add = "INSERT INTO Tickets VALUES (@name, @surname, @exp)";
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter name = new SqlParameter("@name", textBox_pilots_name.Text);
            SqlParameter surname = new SqlParameter("@surname", textBox_pilots_surname.Text);
            SqlParameter exp = new SqlParameter("@exp", numericUpDown_pilots_exp.Value);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_name);
                Proverka_query.Parameters.Add(proverka_surname);
                Add_query.Parameters.Add(name);
                Add_query.Parameters.Add(surname);
                Add_query.Parameters.Add(exp);

                if (textBox_pilots_name.Text != null || textBox_pilots_surname.Text != null || numericUpDown_pilots_exp != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Пилот добавлен!", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Такой пилот уже существует!", "Ошибка!");
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
        private void button_pilots_change_Click(object sender, EventArgs e)
        {

        }
        private void button_pilots_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form = new Form_Admin();
            form.Show();
            this.Close();
        }

    }
}
