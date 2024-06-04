using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.Редактирование
{
    public partial class Form_Airports_Routes_Flights : Form
    {
        public Form_Airports_Routes_Flights()
        {
            InitializeComponent();
        }

        public void UpdateInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Routes". При необходимости она может быть перемещена или удалена.
            this.routesTableAdapter.Fill(this.airportDataSet.Routes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);
        }

        private void Form_Airports_Routes_Flights_Load(object sender, EventArgs e)
        {

        }

        private void button_add_client_Click(object sender, EventArgs e)
        {

        }
        private void button_change_client_Click(object sender, EventArgs e)
        {

        }
        private void button_delete_client_Click(object sender, EventArgs e)
        {

        }

        private void button_route_add_Click(object sender, EventArgs e)
        {

        }
        private void button_route_change_Click(object sender, EventArgs e)
        {

        }
        private void button_route_delete_Click(object sender, EventArgs e)
        {

        }


        private void button_flights_add_Click(object sender, EventArgs e)
        {

        }
        private void button_flights_change_Click(object sender, EventArgs e)
        {

        }
        private void button_flights_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }

    }
}
