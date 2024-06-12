using Airport.Редактирование;
using System;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Prices". При необходимости она может быть перемещена или удалена.
            this.pricesTableAdapter.Fill(this.airportDataSet.Prices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.airportDataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.airportDataSet.Clients);

        }

        private void button_clients_tickets_prices_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
        }
        private void button_first_change_Click(object sender, EventArgs e)
        {
            Form_Clients_Tickets_Prices form = new Form_Clients_Tickets_Prices();
            form.Show();
            this.Close();
        }

        private void button_airports_routes_flights_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Visible = !panel2.Visible;
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
        }
        private void button_second_change_Click(object sender, EventArgs e)
        {
            Form_Airports_Routes_Flights form = new Form_Airports_Routes_Flights();
            form.Show();
            this.Close();
        }

        private void button_classes_numberOfSeats_aircrafts_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Visible = !panel3.Visible;
            panel4.Hide();
            panel5.Hide();
        }
        private void button_third_change_Click(object sender, EventArgs e)
        {
            Form_Classes_NumberOfSeats_Aircrafts form = new Form_Classes_NumberOfSeats_Aircrafts();
            form.Show();
            this.Close();
        }

        private void button_departures_pilots_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Visible = !panel4.Visible;
            panel5.Hide();
        }
        private void button_four_change_Click(object sender, EventArgs e)
        {
            Form_Departures_Pilots form = new Form_Departures_Pilots();
            form.Show();
            this.Close();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Visible = !panel5.Visible;
        }
        private void button_fifth_change_Click(object sender, EventArgs e)
        {
            Form_Users form = new Form_Users();
            form.Show();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            form.Show();
            this.Close();
        }
    }
}
