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
    public partial class Form_Classes_NumberOfSeats_Aircrafts : Form
    {
        public Form_Classes_NumberOfSeats_Aircrafts()
        {
            InitializeComponent();
        }

        private void UpdateInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Aircrafts". При необходимости она может быть перемещена или удалена.
            this.aircraftsTableAdapter.Fill(this.airportDataSet.Aircrafts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.NumberOfSeats". При необходимости она может быть перемещена или удалена.
            this.numberOfSeatsTableAdapter.Fill(this.airportDataSet.NumberOfSeats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.airportDataSet.Classes);
        }

        private void Form_Classes_NumberOfSeats_Aircrafts_Load(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void button_class_add_Click(object sender, EventArgs e)
        {

        }
        private void button_class_change_Click(object sender, EventArgs e)
        {

        }
        private void button_class_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_numberofseats_add_Click(object sender, EventArgs e)
        {

        }
        private void button_numberofseats_change_Click(object sender, EventArgs e)
        {

        }
        private void button_numberofseats_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_aircrafts_add_Click(object sender, EventArgs e)
        {

        }
        private void button_aircrafts_change_Click(object sender, EventArgs e)
        {

        }
        private void button_aircrafts_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }
    }
}
