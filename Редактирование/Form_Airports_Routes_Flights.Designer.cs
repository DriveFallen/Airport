namespace Airport.Редактирование
{
    partial class Form_Airports_Routes_Flights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_airports = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.button_delete_client = new System.Windows.Forms.Button();
            this.button_change_client = new System.Windows.Forms.Button();
            this.button_add_client = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_airports_country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_airports_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_airports_id = new System.Windows.Forms.TextBox();
            this.airportsTableAdapter = new Airport.AirportDataSetTableAdapters.AirportsTableAdapter();
            this.dataGridView_flights = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_routes = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new Airport.AirportDataSetTableAdapters.RoutesTableAdapter();
            this.flightsTableAdapter = new Airport.AirportDataSetTableAdapters.FlightsTableAdapter();
            this.button_route_delete = new System.Windows.Forms.Button();
            this.button_route_change = new System.Windows.Forms.Button();
            this.button_route_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_route_direction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_route_id = new System.Windows.Forms.TextBox();
            this.comboBox_route_airport = new System.Windows.Forms.ComboBox();
            this.comboBox_flight_id_route = new System.Windows.Forms.ComboBox();
            this.button_flights_delete = new System.Windows.Forms.Button();
            this.button_flights_change = new System.Windows.Forms.Button();
            this.button_flights_add = new System.Windows.Forms.Button();
            this.label7_departure_time = new System.Windows.Forms.Label();
            this.textBox_flight_departure_time = new System.Windows.Forms.TextBox();
            this.label8_id_route = new System.Windows.Forms.Label();
            this.label9_id_flight = new System.Windows.Forms.Label();
            this.textBox_flight_id = new System.Windows.Forms.TextBox();
            this.textBox_flight_arrival_time = new System.Windows.Forms.TextBox();
            this.label8_arrival_time = new System.Windows.Forms.Label();
            this.label9_weekday = new System.Windows.Forms.Label();
            this.textBox_fligh_weekday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_airports
            // 
            this.dataGridView_airports.AutoGenerateColumns = false;
            this.dataGridView_airports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_airports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridView_airports.DataSource = this.airportsBindingSource;
            this.dataGridView_airports.Location = new System.Drawing.Point(16, 357);
            this.dataGridView_airports.Name = "dataGridView_airports";
            this.dataGridView_airports.Size = new System.Drawing.Size(478, 296);
            this.dataGridView_airports.TabIndex = 38;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_delete_client
            // 
            this.button_delete_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete_client.Location = new System.Drawing.Point(232, 129);
            this.button_delete_client.Name = "button_delete_client";
            this.button_delete_client.Size = new System.Drawing.Size(97, 29);
            this.button_delete_client.TabIndex = 37;
            this.button_delete_client.Text = "button3";
            this.button_delete_client.UseVisualStyleBackColor = false;
            this.button_delete_client.Click += new System.EventHandler(this.button_delete_client_Click);
            // 
            // button_change_client
            // 
            this.button_change_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_change_client.Location = new System.Drawing.Point(232, 94);
            this.button_change_client.Name = "button_change_client";
            this.button_change_client.Size = new System.Drawing.Size(97, 29);
            this.button_change_client.TabIndex = 36;
            this.button_change_client.Text = "button2";
            this.button_change_client.UseVisualStyleBackColor = false;
            this.button_change_client.Click += new System.EventHandler(this.button_change_client_Click);
            // 
            // button_add_client
            // 
            this.button_add_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add_client.Location = new System.Drawing.Point(232, 59);
            this.button_add_client.Name = "button_add_client";
            this.button_add_client.Size = new System.Drawing.Size(97, 29);
            this.button_add_client.TabIndex = 35;
            this.button_add_client.Text = "button1";
            this.button_add_client.UseVisualStyleBackColor = false;
            this.button_add_client.Click += new System.EventHandler(this.button_add_client_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(1423, 9);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 79);
            this.button_back.TabIndex = 34;
            this.button_back.Text = "button1";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Страна";
            // 
            // textBox_airports_country
            // 
            this.textBox_airports_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_airports_country.Location = new System.Drawing.Point(16, 151);
            this.textBox_airports_country.Name = "textBox_airports_country";
            this.textBox_airports_country.Size = new System.Drawing.Size(175, 26);
            this.textBox_airports_country.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Название";
            // 
            // textBox_airports_name
            // 
            this.textBox_airports_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_airports_name.Location = new System.Drawing.Point(16, 95);
            this.textBox_airports_name.Name = "textBox_airports_name";
            this.textBox_airports_name.Size = new System.Drawing.Size(175, 26);
            this.textBox_airports_name.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Аэропорта";
            // 
            // textBox_airports_id
            // 
            this.textBox_airports_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_airports_id.Location = new System.Drawing.Point(16, 36);
            this.textBox_airports_id.Name = "textBox_airports_id";
            this.textBox_airports_id.Size = new System.Drawing.Size(175, 26);
            this.textBox_airports_id.TabIndex = 26;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_flights
            // 
            this.dataGridView_flights.AutoGenerateColumns = false;
            this.dataGridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.iDRouteDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.weekdayDataGridViewTextBoxColumn});
            this.dataGridView_flights.DataSource = this.flightsBindingSource;
            this.dataGridView_flights.Location = new System.Drawing.Point(884, 357);
            this.dataGridView_flights.Name = "dataGridView_flights";
            this.dataGridView_flights.Size = new System.Drawing.Size(612, 296);
            this.dataGridView_flights.TabIndex = 40;
            this.dataGridView_flights.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iDRouteDataGridViewTextBoxColumn
            // 
            this.iDRouteDataGridViewTextBoxColumn.DataPropertyName = "ID_Route";
            this.iDRouteDataGridViewTextBoxColumn.HeaderText = "ID_Route";
            this.iDRouteDataGridViewTextBoxColumn.Name = "iDRouteDataGridViewTextBoxColumn";
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.HeaderText = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.Name = "weekdayDataGridViewTextBoxColumn";
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airportDataSet;
            // 
            // dataGridView_routes
            // 
            this.dataGridView_routes.AutoGenerateColumns = false;
            this.dataGridView_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_routes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDAirportDataGridViewTextBoxColumn,
            this.directionDataGridViewCheckBoxColumn});
            this.dataGridView_routes.DataSource = this.routesBindingSource;
            this.dataGridView_routes.Location = new System.Drawing.Point(500, 357);
            this.dataGridView_routes.Name = "dataGridView_routes";
            this.dataGridView_routes.Size = new System.Drawing.Size(378, 296);
            this.dataGridView_routes.TabIndex = 39;
            this.dataGridView_routes.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDAirportDataGridViewTextBoxColumn
            // 
            this.iDAirportDataGridViewTextBoxColumn.DataPropertyName = "ID_Airport";
            this.iDAirportDataGridViewTextBoxColumn.HeaderText = "ID_Airport";
            this.iDAirportDataGridViewTextBoxColumn.Name = "iDAirportDataGridViewTextBoxColumn";
            // 
            // directionDataGridViewCheckBoxColumn
            // 
            this.directionDataGridViewCheckBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewCheckBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewCheckBoxColumn.Name = "directionDataGridViewCheckBoxColumn";
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.airportDataSet;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // button_route_delete
            // 
            this.button_route_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_route_delete.Location = new System.Drawing.Point(716, 129);
            this.button_route_delete.Name = "button_route_delete";
            this.button_route_delete.Size = new System.Drawing.Size(97, 29);
            this.button_route_delete.TabIndex = 49;
            this.button_route_delete.Text = "button3";
            this.button_route_delete.UseVisualStyleBackColor = false;
            this.button_route_delete.Click += new System.EventHandler(this.button_route_delete_Click);
            // 
            // button_route_change
            // 
            this.button_route_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_route_change.Location = new System.Drawing.Point(716, 94);
            this.button_route_change.Name = "button_route_change";
            this.button_route_change.Size = new System.Drawing.Size(97, 29);
            this.button_route_change.TabIndex = 48;
            this.button_route_change.Text = "button2";
            this.button_route_change.UseVisualStyleBackColor = false;
            this.button_route_change.Click += new System.EventHandler(this.button_route_change_Click);
            // 
            // button_route_add
            // 
            this.button_route_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_route_add.Location = new System.Drawing.Point(716, 59);
            this.button_route_add.Name = "button_route_add";
            this.button_route_add.Size = new System.Drawing.Size(97, 29);
            this.button_route_add.TabIndex = 47;
            this.button_route_add.Text = "button1";
            this.button_route_add.UseVisualStyleBackColor = false;
            this.button_route_add.Click += new System.EventHandler(this.button_route_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(496, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Направление";
            // 
            // textBox_route_direction
            // 
            this.textBox_route_direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_route_direction.Location = new System.Drawing.Point(500, 151);
            this.textBox_route_direction.Name = "textBox_route_direction";
            this.textBox_route_direction.Size = new System.Drawing.Size(175, 26);
            this.textBox_route_direction.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(496, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Аэропорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(496, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID Маршрута";
            // 
            // textBox_route_id
            // 
            this.textBox_route_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_route_id.Location = new System.Drawing.Point(500, 36);
            this.textBox_route_id.Name = "textBox_route_id";
            this.textBox_route_id.Size = new System.Drawing.Size(175, 26);
            this.textBox_route_id.TabIndex = 41;
            // 
            // comboBox_route_airport
            // 
            this.comboBox_route_airport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_route_airport.FormattingEnabled = true;
            this.comboBox_route_airport.Location = new System.Drawing.Point(500, 95);
            this.comboBox_route_airport.Name = "comboBox_route_airport";
            this.comboBox_route_airport.Size = new System.Drawing.Size(175, 28);
            this.comboBox_route_airport.TabIndex = 50;
            // 
            // comboBox_flight_id_route
            // 
            this.comboBox_flight_id_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_flight_id_route.FormattingEnabled = true;
            this.comboBox_flight_id_route.Location = new System.Drawing.Point(908, 95);
            this.comboBox_flight_id_route.Name = "comboBox_flight_id_route";
            this.comboBox_flight_id_route.Size = new System.Drawing.Size(175, 28);
            this.comboBox_flight_id_route.TabIndex = 59;
            // 
            // button_flights_delete
            // 
            this.button_flights_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_flights_delete.Location = new System.Drawing.Point(1124, 129);
            this.button_flights_delete.Name = "button_flights_delete";
            this.button_flights_delete.Size = new System.Drawing.Size(97, 29);
            this.button_flights_delete.TabIndex = 58;
            this.button_flights_delete.Text = "button3";
            this.button_flights_delete.UseVisualStyleBackColor = false;
            this.button_flights_delete.Click += new System.EventHandler(this.button_flights_delete_Click);
            // 
            // button_flights_change
            // 
            this.button_flights_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_flights_change.Location = new System.Drawing.Point(1124, 94);
            this.button_flights_change.Name = "button_flights_change";
            this.button_flights_change.Size = new System.Drawing.Size(97, 29);
            this.button_flights_change.TabIndex = 57;
            this.button_flights_change.Text = "button2";
            this.button_flights_change.UseVisualStyleBackColor = false;
            this.button_flights_change.Click += new System.EventHandler(this.button_flights_change_Click);
            // 
            // button_flights_add
            // 
            this.button_flights_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_flights_add.Location = new System.Drawing.Point(1124, 59);
            this.button_flights_add.Name = "button_flights_add";
            this.button_flights_add.Size = new System.Drawing.Size(97, 29);
            this.button_flights_add.TabIndex = 56;
            this.button_flights_add.Text = "button1";
            this.button_flights_add.UseVisualStyleBackColor = false;
            this.button_flights_add.Click += new System.EventHandler(this.button_flights_add_Click);
            // 
            // label7_departure_time
            // 
            this.label7_departure_time.AutoSize = true;
            this.label7_departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7_departure_time.ForeColor = System.Drawing.Color.White;
            this.label7_departure_time.Location = new System.Drawing.Point(904, 124);
            this.label7_departure_time.Name = "label7_departure_time";
            this.label7_departure_time.Size = new System.Drawing.Size(119, 20);
            this.label7_departure_time.TabIndex = 55;
            this.label7_departure_time.Text = "Время вылета";
            // 
            // textBox_flight_departure_time
            // 
            this.textBox_flight_departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flight_departure_time.Location = new System.Drawing.Point(908, 151);
            this.textBox_flight_departure_time.Name = "textBox_flight_departure_time";
            this.textBox_flight_departure_time.Size = new System.Drawing.Size(175, 26);
            this.textBox_flight_departure_time.TabIndex = 54;
            // 
            // label8_id_route
            // 
            this.label8_id_route.AutoSize = true;
            this.label8_id_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8_id_route.ForeColor = System.Drawing.Color.White;
            this.label8_id_route.Location = new System.Drawing.Point(904, 68);
            this.label8_id_route.Name = "label8_id_route";
            this.label8_id_route.Size = new System.Drawing.Size(106, 20);
            this.label8_id_route.TabIndex = 53;
            this.label8_id_route.Text = "ID маршрута";
            // 
            // label9_id_flight
            // 
            this.label9_id_flight.AutoSize = true;
            this.label9_id_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9_id_flight.ForeColor = System.Drawing.Color.White;
            this.label9_id_flight.Location = new System.Drawing.Point(904, 9);
            this.label9_id_flight.Name = "label9_id_flight";
            this.label9_id_flight.Size = new System.Drawing.Size(87, 20);
            this.label9_id_flight.TabIndex = 52;
            this.label9_id_flight.Text = "ID вылета";
            // 
            // textBox_flight_id
            // 
            this.textBox_flight_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flight_id.Location = new System.Drawing.Point(908, 36);
            this.textBox_flight_id.Name = "textBox_flight_id";
            this.textBox_flight_id.Size = new System.Drawing.Size(175, 26);
            this.textBox_flight_id.TabIndex = 51;
            // 
            // textBox_flight_arrival_time
            // 
            this.textBox_flight_arrival_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flight_arrival_time.Location = new System.Drawing.Point(908, 211);
            this.textBox_flight_arrival_time.Name = "textBox_flight_arrival_time";
            this.textBox_flight_arrival_time.Size = new System.Drawing.Size(175, 26);
            this.textBox_flight_arrival_time.TabIndex = 60;
            // 
            // label8_arrival_time
            // 
            this.label8_arrival_time.AutoSize = true;
            this.label8_arrival_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8_arrival_time.ForeColor = System.Drawing.Color.White;
            this.label8_arrival_time.Location = new System.Drawing.Point(904, 188);
            this.label8_arrival_time.Name = "label8_arrival_time";
            this.label8_arrival_time.Size = new System.Drawing.Size(136, 20);
            this.label8_arrival_time.TabIndex = 61;
            this.label8_arrival_time.Text = "Время прибытия";
            // 
            // label9_weekday
            // 
            this.label9_weekday.AutoSize = true;
            this.label9_weekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9_weekday.ForeColor = System.Drawing.Color.White;
            this.label9_weekday.Location = new System.Drawing.Point(904, 253);
            this.label9_weekday.Name = "label9_weekday";
            this.label9_weekday.Size = new System.Drawing.Size(109, 20);
            this.label9_weekday.TabIndex = 62;
            this.label9_weekday.Text = "День недели";
            // 
            // textBox_fligh_weekday
            // 
            this.textBox_fligh_weekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fligh_weekday.Location = new System.Drawing.Point(908, 276);
            this.textBox_fligh_weekday.Name = "textBox_fligh_weekday";
            this.textBox_fligh_weekday.Size = new System.Drawing.Size(175, 26);
            this.textBox_fligh_weekday.TabIndex = 63;
            // 
            // Form_Airports_Routes_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1522, 665);
            this.Controls.Add(this.textBox_fligh_weekday);
            this.Controls.Add(this.label9_weekday);
            this.Controls.Add(this.label8_arrival_time);
            this.Controls.Add(this.textBox_flight_arrival_time);
            this.Controls.Add(this.comboBox_flight_id_route);
            this.Controls.Add(this.button_flights_delete);
            this.Controls.Add(this.button_flights_change);
            this.Controls.Add(this.button_flights_add);
            this.Controls.Add(this.label7_departure_time);
            this.Controls.Add(this.textBox_flight_departure_time);
            this.Controls.Add(this.label8_id_route);
            this.Controls.Add(this.label9_id_flight);
            this.Controls.Add(this.textBox_flight_id);
            this.Controls.Add(this.comboBox_route_airport);
            this.Controls.Add(this.button_route_delete);
            this.Controls.Add(this.button_route_change);
            this.Controls.Add(this.button_route_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_route_direction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_route_id);
            this.Controls.Add(this.dataGridView_flights);
            this.Controls.Add(this.dataGridView_routes);
            this.Controls.Add(this.dataGridView_airports);
            this.Controls.Add(this.button_delete_client);
            this.Controls.Add(this.button_change_client);
            this.Controls.Add(this.button_add_client);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_airports_country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_airports_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_airports_id);
            this.Name = "Form_Airports_Routes_Flights";
            this.Text = "Form_Airports_Routes_Flights";
            this.Load += new System.EventHandler(this.Form_Airports_Routes_Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_airports;
        private System.Windows.Forms.Button button_delete_client;
        private System.Windows.Forms.Button button_change_client;
        private System.Windows.Forms.Button button_add_client;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_airports_country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_airports_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_airports_id;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_flights;
        private System.Windows.Forms.DataGridView dataGridView_routes;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private AirportDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn directionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirportDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_route_delete;
        private System.Windows.Forms.Button button_route_change;
        private System.Windows.Forms.Button button_route_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_route_direction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_route_id;
        private System.Windows.Forms.ComboBox comboBox_route_airport;
        private System.Windows.Forms.ComboBox comboBox_flight_id_route;
        private System.Windows.Forms.Button button_flights_delete;
        private System.Windows.Forms.Button button_flights_change;
        private System.Windows.Forms.Button button_flights_add;
        private System.Windows.Forms.Label label7_departure_time;
        private System.Windows.Forms.TextBox textBox_flight_departure_time;
        private System.Windows.Forms.Label label8_id_route;
        private System.Windows.Forms.Label label9_id_flight;
        private System.Windows.Forms.TextBox textBox_flight_id;
        private System.Windows.Forms.TextBox textBox_flight_arrival_time;
        private System.Windows.Forms.Label label8_arrival_time;
        private System.Windows.Forms.Label label9_weekday;
        private System.Windows.Forms.TextBox textBox_fligh_weekday;
    }
}