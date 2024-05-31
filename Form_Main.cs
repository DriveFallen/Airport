using System;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.airportDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Pilots". При необходимости она может быть перемещена или удалена.
            this.pilotsTableAdapter.Fill(this.airportDataSet.Pilots);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Departures". При необходимости она может быть перемещена или удалена.
            this.departuresTableAdapter.Fill(this.airportDataSet.Departures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Aircrafts". При необходимости она может быть перемещена или удалена.
            this.aircraftsTableAdapter.Fill(this.airportDataSet.Aircrafts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.NumberOfSeats". При необходимости она может быть перемещена или удалена.
            this.numberOfSeatsTableAdapter.Fill(this.airportDataSet.NumberOfSeats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.airportDataSet.Classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Routes". При необходимости она может быть перемещена или удалена.
            this.routesTableAdapter.Fill(this.airportDataSet.Routes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Prices". При необходимости она может быть перемещена или удалена.
            this.pricesTableAdapter.Fill(this.airportDataSet.Prices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.airportDataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.FillByCustom(this.airportDataSet.Clients);

        }

        private void button_clients_tickets_prices_Click(object sender, EventArgs e)
        {

        }

        private void button_airports_routes_flights_Click(object sender, EventArgs e)
        {

        }

        private void button_classes_numberOfSeats_aircrafts_Click(object sender, EventArgs e)
        {

        }

        private void button_departures_pilots_Click(object sender, EventArgs e)
        {

        }

        private void button_users_Click(object sender, EventArgs e)
        {

        }
    }
}
