namespace Airport
{
    partial class Form_Admin
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
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.dataGridView_pilots = new System.Windows.Forms.DataGridView();
            this.dataGridView_departures = new System.Windows.Forms.DataGridView();
            this.dataGridView_aircrafts = new System.Windows.Forms.DataGridView();
            this.dataGridView_nuberOfSeats = new System.Windows.Forms.DataGridView();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.dataGridView_flights = new System.Windows.Forms.DataGridView();
            this.dataGridView_routes = new System.Windows.Forms.DataGridView();
            this.dataGridView_airports = new System.Windows.Forms.DataGridView();
            this.dataGridView_prices = new System.Windows.Forms.DataGridView();
            this.dataGridView_tickets = new System.Windows.Forms.DataGridView();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.button_back = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_departures_pilots = new System.Windows.Forms.Button();
            this.button_classes_numberOfSeats_aircrafts = new System.Windows.Forms.Button();
            this.button_airports_routes_flights = new System.Windows.Forms.Button();
            this.button_clients_tickets_prices = new System.Windows.Forms.Button();
            this.button_first_change = new System.Windows.Forms.Button();
            this.button_second_change = new System.Windows.Forms.Button();
            this.button_third_change = new System.Windows.Forms.Button();
            this.button_four_change = new System.Windows.Forms.Button();
            this.button_fifth_change = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clientsTableAdapter = new Airport.AirportDataSetTableAdapters.ClientsTableAdapter();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Airport.AirportDataSetTableAdapters.TicketsTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricesTableAdapter = new Airport.AirportDataSetTableAdapters.PricesTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nuberOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(11, 13);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.Size = new System.Drawing.Size(774, 482);
            this.dataGridView_users.TabIndex = 35;
            // 
            // dataGridView_pilots
            // 
            this.dataGridView_pilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pilots.Location = new System.Drawing.Point(791, 3);
            this.dataGridView_pilots.Name = "dataGridView_pilots";
            this.dataGridView_pilots.Size = new System.Drawing.Size(639, 489);
            this.dataGridView_pilots.TabIndex = 34;
            // 
            // dataGridView_departures
            // 
            this.dataGridView_departures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures.Location = new System.Drawing.Point(11, 3);
            this.dataGridView_departures.Name = "dataGridView_departures";
            this.dataGridView_departures.Size = new System.Drawing.Size(774, 489);
            this.dataGridView_departures.TabIndex = 33;
            // 
            // dataGridView_aircrafts
            // 
            this.dataGridView_aircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aircrafts.Location = new System.Drawing.Point(791, 3);
            this.dataGridView_aircrafts.Name = "dataGridView_aircrafts";
            this.dataGridView_aircrafts.Size = new System.Drawing.Size(639, 498);
            this.dataGridView_aircrafts.TabIndex = 32;
            // 
            // dataGridView_nuberOfSeats
            // 
            this.dataGridView_nuberOfSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nuberOfSeats.Location = new System.Drawing.Point(407, 3);
            this.dataGridView_nuberOfSeats.Name = "dataGridView_nuberOfSeats";
            this.dataGridView_nuberOfSeats.Size = new System.Drawing.Size(378, 498);
            this.dataGridView_nuberOfSeats.TabIndex = 31;
            // 
            // dataGridView_classes
            // 
            this.dataGridView_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classes.Location = new System.Drawing.Point(11, 3);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.Size = new System.Drawing.Size(390, 498);
            this.dataGridView_classes.TabIndex = 30;
            // 
            // dataGridView_flights
            // 
            this.dataGridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flights.Location = new System.Drawing.Point(794, 3);
            this.dataGridView_flights.Name = "dataGridView_flights";
            this.dataGridView_flights.Size = new System.Drawing.Size(639, 495);
            this.dataGridView_flights.TabIndex = 29;
            // 
            // dataGridView_routes
            // 
            this.dataGridView_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_routes.Location = new System.Drawing.Point(410, 3);
            this.dataGridView_routes.Name = "dataGridView_routes";
            this.dataGridView_routes.Size = new System.Drawing.Size(378, 495);
            this.dataGridView_routes.TabIndex = 28;
            // 
            // dataGridView_airports
            // 
            this.dataGridView_airports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_airports.Location = new System.Drawing.Point(14, 3);
            this.dataGridView_airports.Name = "dataGridView_airports";
            this.dataGridView_airports.Size = new System.Drawing.Size(390, 495);
            this.dataGridView_airports.TabIndex = 27;
            // 
            // dataGridView_prices
            // 
            this.dataGridView_prices.AutoGenerateColumns = false;
            this.dataGridView_prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.iDClassDataGridViewTextBoxColumn,
            this.iDDepartureDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_prices.DataSource = this.pricesBindingSource;
            this.dataGridView_prices.Location = new System.Drawing.Point(966, 16);
            this.dataGridView_prices.Name = "dataGridView_prices";
            this.dataGridView_prices.Size = new System.Drawing.Size(467, 471);
            this.dataGridView_prices.TabIndex = 26;
            // 
            // dataGridView_tickets
            // 
            this.dataGridView_tickets.AutoGenerateColumns = false;
            this.dataGridView_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDPriceDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn});
            this.dataGridView_tickets.DataSource = this.ticketsBindingSource;
            this.dataGridView_tickets.Location = new System.Drawing.Point(484, 13);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.Size = new System.Drawing.Size(476, 474);
            this.dataGridView_tickets.TabIndex = 25;
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoGenerateColumns = false;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn});
            this.dataGridView_clients.DataSource = this.clientsBindingSource;
            this.dataGridView_clients.Location = new System.Drawing.Point(14, 13);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(464, 474);
            this.dataGridView_clients.TabIndex = 24;
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
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(1011, 13);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 73);
            this.button_back.TabIndex = 23;
            this.button_back.Text = "Выход";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_users
            // 
            this.button_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_users.Location = new System.Drawing.Point(804, 12);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(192, 74);
            this.button_users.TabIndex = 22;
            this.button_users.Text = "Пользователи";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_departures_pilots
            // 
            this.button_departures_pilots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_departures_pilots.Location = new System.Drawing.Point(606, 12);
            this.button_departures_pilots.Name = "button_departures_pilots";
            this.button_departures_pilots.Size = new System.Drawing.Size(192, 74);
            this.button_departures_pilots.TabIndex = 21;
            this.button_departures_pilots.Text = "Отправления, пилоты";
            this.button_departures_pilots.UseVisualStyleBackColor = true;
            this.button_departures_pilots.Click += new System.EventHandler(this.button_departures_pilots_Click);
            // 
            // button_classes_numberOfSeats_aircrafts
            // 
            this.button_classes_numberOfSeats_aircrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_classes_numberOfSeats_aircrafts.Location = new System.Drawing.Point(408, 13);
            this.button_classes_numberOfSeats_aircrafts.Name = "button_classes_numberOfSeats_aircrafts";
            this.button_classes_numberOfSeats_aircrafts.Size = new System.Drawing.Size(192, 74);
            this.button_classes_numberOfSeats_aircrafts.TabIndex = 20;
            this.button_classes_numberOfSeats_aircrafts.Text = "Классы, Мест в классе, Самолёты";
            this.button_classes_numberOfSeats_aircrafts.UseVisualStyleBackColor = true;
            this.button_classes_numberOfSeats_aircrafts.Click += new System.EventHandler(this.button_classes_numberOfSeats_aircrafts_Click);
            // 
            // button_airports_routes_flights
            // 
            this.button_airports_routes_flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_airports_routes_flights.Location = new System.Drawing.Point(210, 12);
            this.button_airports_routes_flights.Name = "button_airports_routes_flights";
            this.button_airports_routes_flights.Size = new System.Drawing.Size(192, 74);
            this.button_airports_routes_flights.TabIndex = 19;
            this.button_airports_routes_flights.Text = "Аэропорты, Маршруты, Рейсы";
            this.button_airports_routes_flights.UseVisualStyleBackColor = true;
            this.button_airports_routes_flights.Click += new System.EventHandler(this.button_airports_routes_flights_Click);
            // 
            // button_clients_tickets_prices
            // 
            this.button_clients_tickets_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients_tickets_prices.Location = new System.Drawing.Point(12, 12);
            this.button_clients_tickets_prices.Name = "button_clients_tickets_prices";
            this.button_clients_tickets_prices.Size = new System.Drawing.Size(192, 74);
            this.button_clients_tickets_prices.TabIndex = 18;
            this.button_clients_tickets_prices.Text = "Клиенты, билеты, цены";
            this.button_clients_tickets_prices.UseVisualStyleBackColor = true;
            this.button_clients_tickets_prices.Click += new System.EventHandler(this.button_clients_tickets_prices_Click);
            // 
            // button_first_change
            // 
            this.button_first_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_first_change.Location = new System.Drawing.Point(12, 92);
            this.button_first_change.Name = "button_first_change";
            this.button_first_change.Size = new System.Drawing.Size(192, 32);
            this.button_first_change.TabIndex = 36;
            this.button_first_change.Text = "редактировать";
            this.button_first_change.UseVisualStyleBackColor = true;
            this.button_first_change.Click += new System.EventHandler(this.button_first_change_Click);
            // 
            // button_second_change
            // 
            this.button_second_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_second_change.Location = new System.Drawing.Point(210, 92);
            this.button_second_change.Name = "button_second_change";
            this.button_second_change.Size = new System.Drawing.Size(192, 32);
            this.button_second_change.TabIndex = 37;
            this.button_second_change.Text = "редактировать";
            this.button_second_change.UseVisualStyleBackColor = true;
            this.button_second_change.Click += new System.EventHandler(this.button_second_change_Click);
            // 
            // button_third_change
            // 
            this.button_third_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_third_change.Location = new System.Drawing.Point(408, 93);
            this.button_third_change.Name = "button_third_change";
            this.button_third_change.Size = new System.Drawing.Size(192, 32);
            this.button_third_change.TabIndex = 38;
            this.button_third_change.Text = "редактировать";
            this.button_third_change.UseVisualStyleBackColor = true;
            this.button_third_change.Click += new System.EventHandler(this.button_third_change_Click);
            // 
            // button_four_change
            // 
            this.button_four_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_four_change.Location = new System.Drawing.Point(606, 92);
            this.button_four_change.Name = "button_four_change";
            this.button_four_change.Size = new System.Drawing.Size(192, 32);
            this.button_four_change.TabIndex = 39;
            this.button_four_change.Text = "редактировать";
            this.button_four_change.UseVisualStyleBackColor = true;
            this.button_four_change.Click += new System.EventHandler(this.button_four_change_Click);
            // 
            // button_fifth_change
            // 
            this.button_fifth_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fifth_change.Location = new System.Drawing.Point(804, 93);
            this.button_fifth_change.Name = "button_fifth_change";
            this.button_fifth_change.Size = new System.Drawing.Size(192, 32);
            this.button_fifth_change.TabIndex = 40;
            this.button_fifth_change.Text = "редактировать";
            this.button_fifth_change.UseVisualStyleBackColor = true;
            this.button_fifth_change.Click += new System.EventHandler(this.button_fifth_change_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dataGridView_clients);
            this.panel1.Controls.Add(this.dataGridView_tickets);
            this.panel1.Controls.Add(this.dataGridView_prices);
            this.panel1.Location = new System.Drawing.Point(15, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 501);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.dataGridView_airports);
            this.panel2.Controls.Add(this.dataGridView_routes);
            this.panel2.Controls.Add(this.dataGridView_flights);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 501);
            this.panel2.TabIndex = 42;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.dataGridView_classes);
            this.panel3.Controls.Add(this.dataGridView_nuberOfSeats);
            this.panel3.Controls.Add(this.dataGridView_aircrafts);
            this.panel3.Location = new System.Drawing.Point(12, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1422, 501);
            this.panel3.TabIndex = 43;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.dataGridView_departures);
            this.panel4.Controls.Add(this.dataGridView_pilots);
            this.panel4.Location = new System.Drawing.Point(12, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1419, 501);
            this.panel4.TabIndex = 44;
            this.panel4.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.dataGridView_users);
            this.panel5.Location = new System.Drawing.Point(12, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1419, 501);
            this.panel5.TabIndex = 45;
            this.panel5.Visible = false;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.airportDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDPriceDataGridViewTextBoxColumn
            // 
            this.iDPriceDataGridViewTextBoxColumn.DataPropertyName = "ID_Price";
            this.iDPriceDataGridViewTextBoxColumn.HeaderText = "ID_Price";
            this.iDPriceDataGridViewTextBoxColumn.Name = "iDPriceDataGridViewTextBoxColumn";
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            // 
            // pricesBindingSource
            // 
            this.pricesBindingSource.DataMember = "Prices";
            this.pricesBindingSource.DataSource = this.airportDataSet;
            // 
            // pricesTableAdapter
            // 
            this.pricesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iDClassDataGridViewTextBoxColumn
            // 
            this.iDClassDataGridViewTextBoxColumn.DataPropertyName = "ID_Class";
            this.iDClassDataGridViewTextBoxColumn.HeaderText = "ID_Class";
            this.iDClassDataGridViewTextBoxColumn.Name = "iDClassDataGridViewTextBoxColumn";
            // 
            // iDDepartureDataGridViewTextBoxColumn
            // 
            this.iDDepartureDataGridViewTextBoxColumn.DataPropertyName = "ID_Departure";
            this.iDDepartureDataGridViewTextBoxColumn.HeaderText = "ID_Departure";
            this.iDDepartureDataGridViewTextBoxColumn.Name = "iDDepartureDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1446, 678);
            this.Controls.Add(this.button_fifth_change);
            this.Controls.Add(this.button_four_change);
            this.Controls.Add(this.button_third_change);
            this.Controls.Add(this.button_second_change);
            this.Controls.Add(this.button_first_change);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_departures_pilots);
            this.Controls.Add(this.button_classes_numberOfSeats_aircrafts);
            this.Controls.Add(this.button_airports_routes_flights);
            this.Controls.Add(this.button_clients_tickets_prices);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nuberOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.DataGridView dataGridView_pilots;
        private System.Windows.Forms.DataGridView dataGridView_departures;
        private System.Windows.Forms.DataGridView dataGridView_aircrafts;
        private System.Windows.Forms.DataGridView dataGridView_nuberOfSeats;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private System.Windows.Forms.DataGridView dataGridView_flights;
        private System.Windows.Forms.DataGridView dataGridView_routes;
        private System.Windows.Forms.DataGridView dataGridView_airports;
        private System.Windows.Forms.DataGridView dataGridView_prices;
        private System.Windows.Forms.DataGridView dataGridView_tickets;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_departures_pilots;
        private System.Windows.Forms.Button button_classes_numberOfSeats_aircrafts;
        private System.Windows.Forms.Button button_airports_routes_flights;
        private System.Windows.Forms.Button button_clients_tickets_prices;
        private System.Windows.Forms.Button button_first_change;
        private System.Windows.Forms.Button button_second_change;
        private System.Windows.Forms.Button button_third_change;
        private System.Windows.Forms.Button button_four_change;
        private System.Windows.Forms.Button button_fifth_change;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private AirportDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private AirportDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pricesBindingSource;
        private AirportDataSetTableAdapters.PricesTableAdapter pricesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}