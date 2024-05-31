namespace Airport
{
    partial class Form_Main
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
            this.button_clients_tickets_prices = new System.Windows.Forms.Button();
            this.button_airports_routes_flights = new System.Windows.Forms.Button();
            this.button_classes_numberOfSeats_aircrafts = new System.Windows.Forms.Button();
            this.button_departures_pilots = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.airportDataSet = new Airport.AirportDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Airport.AirportDataSetTableAdapters.ClientsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_tickets = new System.Windows.Forms.DataGridView();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Airport.AirportDataSetTableAdapters.TicketsTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_prices = new System.Windows.Forms.DataGridView();
            this.pricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricesTableAdapter = new Airport.AirportDataSetTableAdapters.PricesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_airports = new System.Windows.Forms.DataGridView();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportsTableAdapter = new Airport.AirportDataSetTableAdapters.AirportsTableAdapter();
            this.dataGridView_routes = new System.Windows.Forms.DataGridView();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new Airport.AirportDataSetTableAdapters.RoutesTableAdapter();
            this.dataGridView_flights = new System.Windows.Forms.DataGridView();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new Airport.AirportDataSetTableAdapters.FlightsTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Airport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_aircrafts = new System.Windows.Forms.DataGridView();
            this.dataGridView_nuberOfSeats = new System.Windows.Forms.DataGridView();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Airport.AirportDataSetTableAdapters.ClassesTableAdapter();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfSeatsTableAdapter = new Airport.AirportDataSetTableAdapters.NumberOfSeatsTableAdapter();
            this.iDAircraftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftsTableAdapter = new Airport.AirportDataSetTableAdapters.AircraftsTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_departures = new System.Windows.Forms.DataGridView();
            this.dataGridView_pilots = new System.Windows.Forms.DataGridView();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.departuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departuresTableAdapter = new Airport.AirportDataSetTableAdapters.DeparturesTableAdapter();
            this.pilotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotsTableAdapter = new Airport.AirportDataSetTableAdapters.PilotsTableAdapter();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Airport.AirportDataSetTableAdapters.UsersTableAdapter();
            this.iDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Pilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nuberOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_clients_tickets_prices
            // 
            this.button_clients_tickets_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients_tickets_prices.Location = new System.Drawing.Point(12, 24);
            this.button_clients_tickets_prices.Name = "button_clients_tickets_prices";
            this.button_clients_tickets_prices.Size = new System.Drawing.Size(192, 74);
            this.button_clients_tickets_prices.TabIndex = 0;
            this.button_clients_tickets_prices.Text = "Клиенты, билеты, цены";
            this.button_clients_tickets_prices.UseVisualStyleBackColor = true;
            this.button_clients_tickets_prices.Click += new System.EventHandler(this.button_clients_tickets_prices_Click);
            // 
            // button_airports_routes_flights
            // 
            this.button_airports_routes_flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_airports_routes_flights.Location = new System.Drawing.Point(210, 24);
            this.button_airports_routes_flights.Name = "button_airports_routes_flights";
            this.button_airports_routes_flights.Size = new System.Drawing.Size(192, 74);
            this.button_airports_routes_flights.TabIndex = 1;
            this.button_airports_routes_flights.Text = "Аэропорты, Маршруты, Рейсы";
            this.button_airports_routes_flights.UseVisualStyleBackColor = true;
            this.button_airports_routes_flights.Click += new System.EventHandler(this.button_airports_routes_flights_Click);
            // 
            // button_classes_numberOfSeats_aircrafts
            // 
            this.button_classes_numberOfSeats_aircrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_classes_numberOfSeats_aircrafts.Location = new System.Drawing.Point(408, 25);
            this.button_classes_numberOfSeats_aircrafts.Name = "button_classes_numberOfSeats_aircrafts";
            this.button_classes_numberOfSeats_aircrafts.Size = new System.Drawing.Size(192, 74);
            this.button_classes_numberOfSeats_aircrafts.TabIndex = 2;
            this.button_classes_numberOfSeats_aircrafts.Text = "Классы, Мест в классе, Самолёты";
            this.button_classes_numberOfSeats_aircrafts.UseVisualStyleBackColor = true;
            this.button_classes_numberOfSeats_aircrafts.Click += new System.EventHandler(this.button_classes_numberOfSeats_aircrafts_Click);
            // 
            // button_departures_pilots
            // 
            this.button_departures_pilots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_departures_pilots.Location = new System.Drawing.Point(606, 24);
            this.button_departures_pilots.Name = "button_departures_pilots";
            this.button_departures_pilots.Size = new System.Drawing.Size(192, 74);
            this.button_departures_pilots.TabIndex = 3;
            this.button_departures_pilots.Text = "Отправления, пилоты";
            this.button_departures_pilots.UseVisualStyleBackColor = true;
            this.button_departures_pilots.Click += new System.EventHandler(this.button_departures_pilots_Click);
            // 
            // button_users
            // 
            this.button_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_users.Location = new System.Drawing.Point(804, 24);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(192, 74);
            this.button_users.TabIndex = 4;
            this.button_users.Text = "Пользователи";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(1011, 25);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 73);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Выход";
            this.button_back.UseVisualStyleBackColor = false;
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
            this.dataGridView_clients.Location = new System.Drawing.Point(12, 134);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(452, 67);
            this.dataGridView_clients.TabIndex = 6;
            this.dataGridView_clients.Visible = false;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.airportDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // dataGridView_tickets
            // 
            this.dataGridView_tickets.AutoGenerateColumns = false;
            this.dataGridView_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_Price,
            this.ID_Client,
            this.Seat,
            this.NewPrice});
            this.dataGridView_tickets.DataSource = this.ticketsBindingSource;
            this.dataGridView_tickets.Location = new System.Drawing.Point(470, 134);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.Size = new System.Drawing.Size(551, 67);
            this.dataGridView_tickets.TabIndex = 7;
            this.dataGridView_tickets.Visible = false;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_Price
            // 
            this.ID_Price.DataPropertyName = "ID_Price";
            this.ID_Price.HeaderText = "ID_Price";
            this.ID_Price.Name = "ID_Price";
            // 
            // ID_Client
            // 
            this.ID_Client.DataPropertyName = "ID_Client";
            this.ID_Client.HeaderText = "ID_Client";
            this.ID_Client.Name = "ID_Client";
            // 
            // Seat
            // 
            this.Seat.DataPropertyName = "Seat";
            this.Seat.HeaderText = "Seat";
            this.Seat.Name = "Seat";
            // 
            // NewPrice
            // 
            this.NewPrice.DataPropertyName = "NewPrice";
            this.NewPrice.HeaderText = "NewPrice";
            this.NewPrice.Name = "NewPrice";
            // 
            // dataGridView_prices
            // 
            this.dataGridView_prices.AutoGenerateColumns = false;
            this.dataGridView_prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ID_Class,
            this.ID_Departure,
            this.Price});
            this.dataGridView_prices.DataSource = this.pricesBindingSource;
            this.dataGridView_prices.Location = new System.Drawing.Point(1027, 134);
            this.dataGridView_prices.Name = "dataGridView_prices";
            this.dataGridView_prices.Size = new System.Drawing.Size(404, 67);
            this.dataGridView_prices.TabIndex = 8;
            this.dataGridView_prices.Visible = false;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ID_Class
            // 
            this.ID_Class.DataPropertyName = "ID_Class";
            this.ID_Class.HeaderText = "ID_Class";
            this.ID_Class.Name = "ID_Class";
            // 
            // ID_Departure
            // 
            this.ID_Departure.DataPropertyName = "ID_Departure";
            this.ID_Departure.HeaderText = "ID_Departure";
            this.ID_Departure.Name = "ID_Departure";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // dataGridView_airports
            // 
            this.dataGridView_airports.AutoGenerateColumns = false;
            this.dataGridView_airports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_airports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Name,
            this.Country});
            this.dataGridView_airports.DataSource = this.airportsBindingSource;
            this.dataGridView_airports.Location = new System.Drawing.Point(12, 207);
            this.dataGridView_airports.Name = "dataGridView_airports";
            this.dataGridView_airports.Size = new System.Drawing.Size(390, 67);
            this.dataGridView_airports.TabIndex = 9;
            this.dataGridView_airports.Visible = false;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_routes
            // 
            this.dataGridView_routes.AutoGenerateColumns = false;
            this.dataGridView_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_routes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ID_Airport,
            this.Direction});
            this.dataGridView_routes.DataSource = this.routesBindingSource;
            this.dataGridView_routes.Location = new System.Drawing.Point(408, 207);
            this.dataGridView_routes.Name = "dataGridView_routes";
            this.dataGridView_routes.Size = new System.Drawing.Size(378, 67);
            this.dataGridView_routes.TabIndex = 10;
            this.dataGridView_routes.Visible = false;
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
            // dataGridView_flights
            // 
            this.dataGridView_flights.AutoGenerateColumns = false;
            this.dataGridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.ID_Route,
            this.DepartureTime,
            this.ArrivalTime,
            this.Weekday});
            this.dataGridView_flights.DataSource = this.flightsBindingSource;
            this.dataGridView_flights.Location = new System.Drawing.Point(792, 207);
            this.dataGridView_flights.Name = "dataGridView_flights";
            this.dataGridView_flights.Size = new System.Drawing.Size(639, 67);
            this.dataGridView_flights.TabIndex = 11;
            this.dataGridView_flights.Visible = false;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airportDataSet;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ID_Airport
            // 
            this.ID_Airport.DataPropertyName = "ID_Airport";
            this.ID_Airport.HeaderText = "ID_Airport";
            this.ID_Airport.Name = "ID_Airport";
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "Direction";
            this.Direction.Name = "Direction";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ID_Route
            // 
            this.ID_Route.DataPropertyName = "ID_Route";
            this.ID_Route.HeaderText = "ID_Route";
            this.ID_Route.Name = "ID_Route";
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.Name = "DepartureTime";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // Weekday
            // 
            this.Weekday.DataPropertyName = "Weekday";
            this.Weekday.HeaderText = "Weekday";
            this.Weekday.Name = "Weekday";
            // 
            // dataGridView_aircrafts
            // 
            this.dataGridView_aircrafts.AutoGenerateColumns = false;
            this.dataGridView_aircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aircrafts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.numberOfSeatsDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.dataGridView_aircrafts.DataSource = this.aircraftsBindingSource;
            this.dataGridView_aircrafts.Location = new System.Drawing.Point(792, 280);
            this.dataGridView_aircrafts.Name = "dataGridView_aircrafts";
            this.dataGridView_aircrafts.Size = new System.Drawing.Size(639, 67);
            this.dataGridView_aircrafts.TabIndex = 14;
            this.dataGridView_aircrafts.Visible = false;
            // 
            // dataGridView_nuberOfSeats
            // 
            this.dataGridView_nuberOfSeats.AutoGenerateColumns = false;
            this.dataGridView_nuberOfSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nuberOfSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAircraftDataGridViewTextBoxColumn,
            this.iDClassDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
            this.dataGridView_nuberOfSeats.DataSource = this.numberOfSeatsBindingSource;
            this.dataGridView_nuberOfSeats.Location = new System.Drawing.Point(408, 280);
            this.dataGridView_nuberOfSeats.Name = "dataGridView_nuberOfSeats";
            this.dataGridView_nuberOfSeats.Size = new System.Drawing.Size(378, 67);
            this.dataGridView_nuberOfSeats.TabIndex = 13;
            this.dataGridView_nuberOfSeats.Visible = false;
            // 
            // dataGridView_classes
            // 
            this.dataGridView_classes.AutoGenerateColumns = false;
            this.dataGridView_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView_classes.DataSource = this.classesBindingSource;
            this.dataGridView_classes.Location = new System.Drawing.Point(12, 280);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.Size = new System.Drawing.Size(390, 67);
            this.dataGridView_classes.TabIndex = 12;
            this.dataGridView_classes.Visible = false;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.airportDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // numberOfSeatsBindingSource
            // 
            this.numberOfSeatsBindingSource.DataMember = "NumberOfSeats";
            this.numberOfSeatsBindingSource.DataSource = this.airportDataSet;
            // 
            // numberOfSeatsTableAdapter
            // 
            this.numberOfSeatsTableAdapter.ClearBeforeFill = true;
            // 
            // iDAircraftDataGridViewTextBoxColumn
            // 
            this.iDAircraftDataGridViewTextBoxColumn.DataPropertyName = "ID_Aircraft";
            this.iDAircraftDataGridViewTextBoxColumn.HeaderText = "ID_Aircraft";
            this.iDAircraftDataGridViewTextBoxColumn.Name = "iDAircraftDataGridViewTextBoxColumn";
            // 
            // iDClassDataGridViewTextBoxColumn
            // 
            this.iDClassDataGridViewTextBoxColumn.DataPropertyName = "ID_Class";
            this.iDClassDataGridViewTextBoxColumn.HeaderText = "ID_Class";
            this.iDClassDataGridViewTextBoxColumn.Name = "iDClassDataGridViewTextBoxColumn";
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            // 
            // aircraftsBindingSource
            // 
            this.aircraftsBindingSource.DataMember = "Aircrafts";
            this.aircraftsBindingSource.DataSource = this.airportDataSet;
            // 
            // aircraftsTableAdapter
            // 
            this.aircraftsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn1
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn1.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn1.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn1.Name = "numberOfSeatsDataGridViewTextBoxColumn1";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // dataGridView_departures
            // 
            this.dataGridView_departures.AutoGenerateColumns = false;
            this.dataGridView_departures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.ID_Aircraft,
            this.ID_Flight,
            this.ID_Pilot,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_departures.DataSource = this.departuresBindingSource;
            this.dataGridView_departures.Location = new System.Drawing.Point(12, 353);
            this.dataGridView_departures.Name = "dataGridView_departures";
            this.dataGridView_departures.Size = new System.Drawing.Size(774, 67);
            this.dataGridView_departures.TabIndex = 15;
            this.dataGridView_departures.Visible = false;
            // 
            // dataGridView_pilots
            // 
            this.dataGridView_pilots.AutoGenerateColumns = false;
            this.dataGridView_pilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pilots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.expirienceDataGridViewTextBoxColumn});
            this.dataGridView_pilots.DataSource = this.pilotsBindingSource;
            this.dataGridView_pilots.Location = new System.Drawing.Point(792, 353);
            this.dataGridView_pilots.Name = "dataGridView_pilots";
            this.dataGridView_pilots.Size = new System.Drawing.Size(639, 67);
            this.dataGridView_pilots.TabIndex = 16;
            this.dataGridView_pilots.Visible = false;
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AutoGenerateColumns = false;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn4,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.hashPasswordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView_users.DataSource = this.usersBindingSource;
            this.dataGridView_users.Location = new System.Drawing.Point(12, 426);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.Size = new System.Drawing.Size(774, 67);
            this.dataGridView_users.TabIndex = 17;
            this.dataGridView_users.Visible = false;
            // 
            // departuresBindingSource
            // 
            this.departuresBindingSource.DataMember = "Departures";
            this.departuresBindingSource.DataSource = this.airportDataSet;
            // 
            // departuresTableAdapter
            // 
            this.departuresTableAdapter.ClearBeforeFill = true;
            // 
            // pilotsBindingSource
            // 
            this.pilotsBindingSource.DataMember = "Pilots";
            this.pilotsBindingSource.DataSource = this.airportDataSet;
            // 
            // pilotsTableAdapter
            // 
            this.pilotsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // expirienceDataGridViewTextBoxColumn
            // 
            this.expirienceDataGridViewTextBoxColumn.DataPropertyName = "Expirience";
            this.expirienceDataGridViewTextBoxColumn.HeaderText = "Expirience";
            this.expirienceDataGridViewTextBoxColumn.Name = "expirienceDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.airportDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn4
            // 
            this.iDDataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn4.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn4.Name = "iDDataGridViewTextBoxColumn4";
            this.iDDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // hashPasswordDataGridViewTextBoxColumn
            // 
            this.hashPasswordDataGridViewTextBoxColumn.DataPropertyName = "HashPassword";
            this.hashPasswordDataGridViewTextBoxColumn.HeaderText = "HashPassword";
            this.hashPasswordDataGridViewTextBoxColumn.Name = "hashPasswordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ID_Aircraft
            // 
            this.ID_Aircraft.DataPropertyName = "ID_Aircraft";
            this.ID_Aircraft.HeaderText = "ID_Aircraft";
            this.ID_Aircraft.Name = "ID_Aircraft";
            // 
            // ID_Flight
            // 
            this.ID_Flight.DataPropertyName = "ID_Flight";
            this.ID_Flight.HeaderText = "ID_Flight";
            this.ID_Flight.Name = "ID_Flight";
            // 
            // ID_Pilot
            // 
            this.ID_Pilot.DataPropertyName = "ID_Pilot";
            this.ID_Pilot.HeaderText = "ID_Pilot";
            this.ID_Pilot.Name = "ID_Pilot";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1443, 592);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.dataGridView_pilots);
            this.Controls.Add(this.dataGridView_departures);
            this.Controls.Add(this.dataGridView_aircrafts);
            this.Controls.Add(this.dataGridView_nuberOfSeats);
            this.Controls.Add(this.dataGridView_classes);
            this.Controls.Add(this.dataGridView_flights);
            this.Controls.Add(this.dataGridView_routes);
            this.Controls.Add(this.dataGridView_airports);
            this.Controls.Add(this.dataGridView_prices);
            this.Controls.Add(this.dataGridView_tickets);
            this.Controls.Add(this.dataGridView_clients);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_departures_pilots);
            this.Controls.Add(this.button_classes_numberOfSeats_aircrafts);
            this.Controls.Add(this.button_airports_routes_flights);
            this.Controls.Add(this.button_clients_tickets_prices);
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_airports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_routes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nuberOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clients_tickets_prices;
        private System.Windows.Forms.Button button_airports_routes_flights;
        private System.Windows.Forms.Button button_classes_numberOfSeats_aircrafts;
        private System.Windows.Forms.Button button_departures_pilots;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private AirportDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_tickets;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private AirportDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewPrice;
        private System.Windows.Forms.DataGridView dataGridView_prices;
        private System.Windows.Forms.BindingSource pricesBindingSource;
        private AirportDataSetTableAdapters.PricesTableAdapter pricesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView_airports;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_routes;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private AirportDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_flights;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirportDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Airport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridView dataGridView_aircrafts;
        private System.Windows.Forms.DataGridView dataGridView_nuberOfSeats;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private AirportDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource numberOfSeatsBindingSource;
        private AirportDataSetTableAdapters.NumberOfSeatsTableAdapter numberOfSeatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAircraftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aircraftsBindingSource;
        private AirportDataSetTableAdapters.AircraftsTableAdapter aircraftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_departures;
        private System.Windows.Forms.DataGridView dataGridView_pilots;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.BindingSource departuresBindingSource;
        private AirportDataSetTableAdapters.DeparturesTableAdapter departuresTableAdapter;
        private System.Windows.Forms.BindingSource pilotsBindingSource;
        private AirportDataSetTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AirportDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}