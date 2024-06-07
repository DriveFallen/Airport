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
    public partial class Form_Classes_NumberOfSeats_Aircrafts : Form
    {
        public SqlConnection connection;

        public Form_Classes_NumberOfSeats_Aircrafts()
        {
            InitializeComponent();
            string connectionString = @"Data Source=WIN-GOSD7FOPDHE\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Aircrafts". При необходимости она может быть перемещена или удалена.
            this.aircraftsTableAdapter.Fill(this.airportDataSet.Aircrafts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.NumberOfSeats". При необходимости она может быть перемещена или удалена.
            this.numberOfSeatsTableAdapter.Fill(this.airportDataSet.NumberOfSeats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.airportDataSet.Classes);

            comboBox_numberOfSeats_aircraft.Items.Clear();
            comboBox_numberOfSeats_classes.Items.Clear();

            foreach (DataGridViewRow row in dataGridView_aircrafts.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_numberOfSeats_aircraft.Items.Add(cellValue);
                }
            }

            foreach (DataGridViewRow row in dataGridView_classes.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_numberOfSeats_classes.Items.Add(cellValue);
                }
            }
        }

        private void Form_Classes_NumberOfSeats_Aircrafts_Load(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void button_class_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Classes WHERE Name = @name";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_name = new SqlParameter("@name", textBox_classes_name.Text);

            string Add = "INSERT INTO Classes VALUES (@name)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter name = new SqlParameter("@name", textBox_classes_name.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_name);
                Add_query.Parameters.Add(name);

                if (textBox_classes_name.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Класс добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Класс с таким названием уже есть в базе", "Ошибка!");
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
        private void button_class_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Classes WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_classes_id.Text);

            string Change = "UPDATE Classes SET Name = @name WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter ID = new SqlParameter("@id", textBox_classes_id.Text);
            SqlParameter name = new SqlParameter("@name", textBox_classes_name.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(ID);
                Change_query.Parameters.Add(name);

                if (textBox_classes_id.Text != null || textBox_classes_name.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные класса изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Класс с таким ID не найден", "Ошибка!");
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
        private void button_class_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Classes WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_classes_id.Text);
           
            string Delete = "DELETE FROM Classes WHERE ID = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_classes_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_query.Parameters.Add(id);

                if (textBox_classes_id.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Класс удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Класс с таким ID не найден", "Ошибка!");
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

        private void button_numberofseats_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM NumberOfSeats WHERE ID_Aircraft = @aircraft and ID_Class = (SELECT ID FROM Classes WHERE Name = @class)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);


            string Add = "INSERT INTO NumberOfSeats VALUES (@aircraft, (SELECT ID FROM Classes WHERE Name = @class), @seats)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter aircraft_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);
            SqlParameter seats = new SqlParameter("@seats", numericUpDown_numberOfSeats_seats.Value);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_aircraft);
                Proverka_query.Parameters.Add(proverka_class);
                Add_query.Parameters.Add(aircraft);
                Add_query.Parameters.Add(aircraft_class);
                Add_query.Parameters.Add(seats);
                
                if (comboBox_numberOfSeats_aircraft.Text != null || comboBox_numberOfSeats_classes.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Данные о местах в самолёте добавлены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Данные о местах в самолёте с данной конфигурацией уже есть в базе", "Ошибка!");
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
        private void button_numberofseats_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM NumberOfSeats WHERE ID_Aircraft = @aircraft and ID_Class = (SELECT ID FROM Classes WHERE Name = @class)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);

            string Change = "UPDATE NumberOfSeats SET NumberOfSeats = @seats WHERE ID_Aircraft = @aircraft and ID_Class = (SELECT ID FROM Classes WHERE Name = @class)";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter aircraf_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);
            SqlParameter seats = new SqlParameter("@seats", numericUpDown_numberOfSeats_seats.Value);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_aircraft);
                Proverka_query.Parameters.Add(proverka_class);
                Change_query.Parameters.Add(aircraft);
                Change_query.Parameters.Add(aircraf_class);
                Change_query.Parameters.Add(seats);


                if (comboBox_numberOfSeats_aircraft.Text != null || comboBox_numberOfSeats_classes.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные о местах в самолёте изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Данные о местах в самолёте с данной конфигурацией не найдены в базе", "Ошибка!");
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
        private void button_numberofseats_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM NumberOfSeats WHERE ID_Aircraft = @aircraft and ID_Class = (SELECT ID FROM Classes WHERE Name = @class)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter proverka_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);

            string Delete = "DELETE FROM NumberOfSeats WHERE ID_Aircraft = @aircraft and ID_Class = (SELECT ID FROM Classes WHERE Name = @class)";
            SqlCommand Change_query = new SqlCommand(Delete, connection);
            SqlParameter aircraft = new SqlParameter("@aircraft", comboBox_numberOfSeats_aircraft.Text);
            SqlParameter aircraft_class = new SqlParameter("@class", comboBox_numberOfSeats_classes.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_aircraft);
                Proverka_query.Parameters.Add(proverka_class);
                Change_query.Parameters.Add(aircraft);
                Change_query.Parameters.Add(aircraft_class);

                if (comboBox_numberOfSeats_aircraft.Text != null || comboBox_numberOfSeats_classes.Text != null) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные о распределении мест в самолете удалёны", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Данные о распределении мест в самолете данной конфигурации не найдены в базе", "Ошибка!");
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

        private void button_aircrafts_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Aircrafts WHERE Model = @model and Company = @copmpany";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_model = new SqlParameter("@model", textBox_aircrafts_model.Text);
            SqlParameter proverka_copmpany = new SqlParameter("@copmpany", textBox_aircrafts_company.Text);

            string Add = "INSERT INTO Aircrafts VALUES (@seats, @model, @company)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter seats = new SqlParameter("@seats", numericUpDown_aircrafts_seats.Value);
            SqlParameter model = new SqlParameter("@model", textBox_aircrafts_model.Text);
            SqlParameter copmpany = new SqlParameter("@company", textBox_aircrafts_company.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_model);
                Proverka_query.Parameters.Add(proverka_copmpany);
                Add_query.Parameters.Add(seats);
                Add_query.Parameters.Add(model);
                Add_query.Parameters.Add(copmpany);

                if (numericUpDown_aircrafts_seats.Text != null || textBox_aircrafts_model.Text != null || textBox_aircrafts_company.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Самолёт добавлен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт такой модели и компании уже есть в базе", "Ошибка!");
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
        private void button_aircrafts_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Aircrafts WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_aircrafts_id.Text);

            string Change = "UPDATE Aircrafts SET NumberOfSeats = @seats, Model = @model, Company = @company WHERE ID = @id";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter id = new SqlParameter("@id", textBox_aircrafts_id.Text);
            SqlParameter seats = new SqlParameter("@seats", numericUpDown_aircrafts_seats.Value);
            SqlParameter model = new SqlParameter("@model", textBox_aircrafts_model.Text);
            SqlParameter company = new SqlParameter("@company", textBox_aircrafts_company.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_query.Parameters.Add(id);
                Change_query.Parameters.Add(seats);
                Change_query.Parameters.Add(model);
                Change_query.Parameters.Add(company);

                if (textBox_aircrafts_id.Text != null || textBox_aircrafts_model.Text != null || textBox_aircrafts_company.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Самолёт изменен", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт с таким ID не найден", "Ошибка!");
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
        private void button_aircrafts_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Aircrafts WHERE ID = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_aircrafts_id.Text);

            string Delete = "DELETE FROM Aircrafts WHERE ID = @id";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter id = new SqlParameter("@id", textBox_aircrafts_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_query.Parameters.Add(id);

                if (textBox_classes_id.Text != null)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Самолёт удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт с таким ID не найден", "Ошибка!");
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
