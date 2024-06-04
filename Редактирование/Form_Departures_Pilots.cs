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
    public partial class Form_Departures_Pilots : Form
    {
        public Form_Departures_Pilots()
        {
            InitializeComponent();
        }

        private void Form_Departures_Pilots_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Pilots". При необходимости она может быть перемещена или удалена.
            this.pilotsTableAdapter.Fill(this.airportDataSet.Pilots);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Departures". При необходимости она может быть перемещена или удалена.
            this.departuresTableAdapter.Fill(this.airportDataSet.Departures);

        }
    }
}
