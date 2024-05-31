namespace Airport.Редактирование
{
    partial class Form_Clients_Tickets_Prices
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
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.button_delete_client = new System.Windows.Forms.Button();
            this.button_change_client = new System.Windows.Forms.Button();
            this.button_add_client = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idPassport_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_surname_client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID_client = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new Airport.AirportDataSetTableAdapters.ClientsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ticket_seat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ticket_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ticket_price = new System.Windows.Forms.TextBox();
            this.comboBox_ticket_price = new System.Windows.Forms.ComboBox();
            this.comboBox_ticket_client = new System.Windows.Forms.ComboBox();
            this.button_ticket_delete = new System.Windows.Forms.Button();
            this.button_ticket_change = new System.Windows.Forms.Button();
            this.button_ticket_add = new System.Windows.Forms.Button();
            this.comboBox_price_departure = new System.Windows.Forms.ComboBox();
            this.comboBox_price_class = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_price_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_price_id = new System.Windows.Forms.TextBox();
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
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_price_delete = new System.Windows.Forms.Button();
            this.button_price_change = new System.Windows.Forms.Button();
            this.button_price_add = new System.Windows.Forms.Button();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Airport.AirportDataSetTableAdapters.ClassesTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_departures = new System.Windows.Forms.DataGridView();
            this.departuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departuresTableAdapter = new Airport.AirportDataSetTableAdapters.DeparturesTableAdapter();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAircraftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPilotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView_clients.Location = new System.Drawing.Point(16, 277);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(478, 296);
            this.dataGridView_clients.TabIndex = 25;
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
            // button_delete_client
            // 
            this.button_delete_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete_client.Location = new System.Drawing.Point(238, 165);
            this.button_delete_client.Name = "button_delete_client";
            this.button_delete_client.Size = new System.Drawing.Size(97, 29);
            this.button_delete_client.TabIndex = 24;
            this.button_delete_client.Text = "button3";
            this.button_delete_client.UseVisualStyleBackColor = false;
            this.button_delete_client.Click += new System.EventHandler(this.button_delete_client_Click);
            // 
            // button_change_client
            // 
            this.button_change_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_change_client.Location = new System.Drawing.Point(238, 130);
            this.button_change_client.Name = "button_change_client";
            this.button_change_client.Size = new System.Drawing.Size(97, 29);
            this.button_change_client.TabIndex = 23;
            this.button_change_client.Text = "button2";
            this.button_change_client.UseVisualStyleBackColor = false;
            this.button_change_client.Click += new System.EventHandler(this.button_change_client_Click);
            // 
            // button_add_client
            // 
            this.button_add_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add_client.Location = new System.Drawing.Point(238, 95);
            this.button_add_client.Name = "button_add_client";
            this.button_add_client.Size = new System.Drawing.Size(97, 29);
            this.button_add_client.TabIndex = 22;
            this.button_add_client.Text = "button1";
            this.button_add_client.UseVisualStyleBackColor = false;
            this.button_add_client.Click += new System.EventHandler(this.button_add_client_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(1439, 14);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 86);
            this.button_back.TabIndex = 21;
            this.button_back.Text = "button1";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "passport number";
            // 
            // textBox_idPassport_client
            // 
            this.textBox_idPassport_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_idPassport_client.Location = new System.Drawing.Point(16, 207);
            this.textBox_idPassport_client.Name = "textBox_idPassport_client";
            this.textBox_idPassport_client.Size = new System.Drawing.Size(175, 26);
            this.textBox_idPassport_client.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Surname";
            // 
            // textBox_surname_client
            // 
            this.textBox_surname_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname_client.Location = new System.Drawing.Point(16, 151);
            this.textBox_surname_client.Name = "textBox_surname_client";
            this.textBox_surname_client.Size = new System.Drawing.Size(175, 26);
            this.textBox_surname_client.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // textBox_name_client
            // 
            this.textBox_name_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_client.Location = new System.Drawing.Point(16, 95);
            this.textBox_name_client.Name = "textBox_name_client";
            this.textBox_name_client.Size = new System.Drawing.Size(175, 26);
            this.textBox_name_client.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Клиента";
            // 
            // textBox_ID_client
            // 
            this.textBox_ID_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ID_client.Location = new System.Drawing.Point(16, 36);
            this.textBox_ID_client.Name = "textBox_ID_client";
            this.textBox_ID_client.Size = new System.Drawing.Size(175, 26);
            this.textBox_ID_client.TabIndex = 13;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(429, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Посадочное место";
            // 
            // textBox_ticket_seat
            // 
            this.textBox_ticket_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ticket_seat.Location = new System.Drawing.Point(433, 216);
            this.textBox_ticket_seat.Name = "textBox_ticket_seat";
            this.textBox_ticket_seat.Size = new System.Drawing.Size(175, 26);
            this.textBox_ticket_seat.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(429, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Клиент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(429, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ценник";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(429, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID Билета";
            // 
            // textBox_ticket_id
            // 
            this.textBox_ticket_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ticket_id.Location = new System.Drawing.Point(433, 41);
            this.textBox_ticket_id.Name = "textBox_ticket_id";
            this.textBox_ticket_id.Size = new System.Drawing.Size(175, 26);
            this.textBox_ticket_id.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(625, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Новая цена";
            // 
            // textBox_ticket_price
            // 
            this.textBox_ticket_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ticket_price.Location = new System.Drawing.Point(629, 41);
            this.textBox_ticket_price.Name = "textBox_ticket_price";
            this.textBox_ticket_price.Size = new System.Drawing.Size(175, 26);
            this.textBox_ticket_price.TabIndex = 34;
            // 
            // comboBox_ticket_price
            // 
            this.comboBox_ticket_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ticket_price.FormattingEnabled = true;
            this.comboBox_ticket_price.Location = new System.Drawing.Point(433, 100);
            this.comboBox_ticket_price.Name = "comboBox_ticket_price";
            this.comboBox_ticket_price.Size = new System.Drawing.Size(175, 28);
            this.comboBox_ticket_price.TabIndex = 36;
            // 
            // comboBox_ticket_client
            // 
            this.comboBox_ticket_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ticket_client.FormattingEnabled = true;
            this.comboBox_ticket_client.Location = new System.Drawing.Point(433, 158);
            this.comboBox_ticket_client.Name = "comboBox_ticket_client";
            this.comboBox_ticket_client.Size = new System.Drawing.Size(175, 28);
            this.comboBox_ticket_client.TabIndex = 37;
            // 
            // button_ticket_delete
            // 
            this.button_ticket_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_ticket_delete.Location = new System.Drawing.Point(671, 171);
            this.button_ticket_delete.Name = "button_ticket_delete";
            this.button_ticket_delete.Size = new System.Drawing.Size(97, 29);
            this.button_ticket_delete.TabIndex = 40;
            this.button_ticket_delete.Text = "button3";
            this.button_ticket_delete.UseVisualStyleBackColor = false;
            this.button_ticket_delete.Click += new System.EventHandler(this.button_ticket_delete_Click);
            // 
            // button_ticket_change
            // 
            this.button_ticket_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ticket_change.Location = new System.Drawing.Point(671, 135);
            this.button_ticket_change.Name = "button_ticket_change";
            this.button_ticket_change.Size = new System.Drawing.Size(97, 29);
            this.button_ticket_change.TabIndex = 39;
            this.button_ticket_change.Text = "button2";
            this.button_ticket_change.UseVisualStyleBackColor = false;
            this.button_ticket_change.Click += new System.EventHandler(this.button_ticket_change_Click);
            // 
            // button_ticket_add
            // 
            this.button_ticket_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ticket_add.Location = new System.Drawing.Point(671, 100);
            this.button_ticket_add.Name = "button_ticket_add";
            this.button_ticket_add.Size = new System.Drawing.Size(97, 29);
            this.button_ticket_add.TabIndex = 38;
            this.button_ticket_add.Text = "button1";
            this.button_ticket_add.UseVisualStyleBackColor = false;
            this.button_ticket_add.Click += new System.EventHandler(this.button_ticket_add_Click);
            // 
            // comboBox_price_departure
            // 
            this.comboBox_price_departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_price_departure.FormattingEnabled = true;
            this.comboBox_price_departure.Location = new System.Drawing.Point(969, 158);
            this.comboBox_price_departure.Name = "comboBox_price_departure";
            this.comboBox_price_departure.Size = new System.Drawing.Size(175, 28);
            this.comboBox_price_departure.TabIndex = 48;
            // 
            // comboBox_price_class
            // 
            this.comboBox_price_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_price_class.FormattingEnabled = true;
            this.comboBox_price_class.Location = new System.Drawing.Point(969, 100);
            this.comboBox_price_class.Name = "comboBox_price_class";
            this.comboBox_price_class.Size = new System.Drawing.Size(175, 28);
            this.comboBox_price_class.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(965, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Цена";
            // 
            // textBox_price_price
            // 
            this.textBox_price_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price_price.Location = new System.Drawing.Point(969, 216);
            this.textBox_price_price.Name = "textBox_price_price";
            this.textBox_price_price.Size = new System.Drawing.Size(175, 26);
            this.textBox_price_price.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(965, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Отправление";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(965, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Класс";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(965, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "ID Ценника";
            // 
            // textBox_price_id
            // 
            this.textBox_price_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price_id.Location = new System.Drawing.Point(969, 41);
            this.textBox_price_id.Name = "textBox_price_id";
            this.textBox_price_id.Size = new System.Drawing.Size(175, 26);
            this.textBox_price_id.TabIndex = 41;
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
            this.dataGridView_tickets.Location = new System.Drawing.Point(500, 277);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.Size = new System.Drawing.Size(531, 296);
            this.dataGridView_tickets.TabIndex = 49;
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
            this.iDDataGridViewTextBoxColumn1,
            this.iDClassDataGridViewTextBoxColumn,
            this.iDDepartureDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_prices.DataSource = this.pricesBindingSource;
            this.dataGridView_prices.Location = new System.Drawing.Point(1037, 277);
            this.dataGridView_prices.Name = "dataGridView_prices";
            this.dataGridView_prices.Size = new System.Drawing.Size(478, 296);
            this.dataGridView_prices.TabIndex = 50;
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
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // button_price_delete
            // 
            this.button_price_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_price_delete.Location = new System.Drawing.Point(1219, 158);
            this.button_price_delete.Name = "button_price_delete";
            this.button_price_delete.Size = new System.Drawing.Size(97, 29);
            this.button_price_delete.TabIndex = 53;
            this.button_price_delete.Text = "button3";
            this.button_price_delete.UseVisualStyleBackColor = false;
            this.button_price_delete.Click += new System.EventHandler(this.button_price_delete_Click);
            // 
            // button_price_change
            // 
            this.button_price_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_price_change.Location = new System.Drawing.Point(1219, 122);
            this.button_price_change.Name = "button_price_change";
            this.button_price_change.Size = new System.Drawing.Size(97, 29);
            this.button_price_change.TabIndex = 52;
            this.button_price_change.Text = "button2";
            this.button_price_change.UseVisualStyleBackColor = false;
            this.button_price_change.Click += new System.EventHandler(this.button_price_change_Click);
            // 
            // button_price_add
            // 
            this.button_price_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_price_add.Location = new System.Drawing.Point(1219, 87);
            this.button_price_add.Name = "button_price_add";
            this.button_price_add.Size = new System.Drawing.Size(97, 29);
            this.button_price_add.TabIndex = 51;
            this.button_price_add.Text = "button1";
            this.button_price_add.UseVisualStyleBackColor = false;
            this.button_price_add.Click += new System.EventHandler(this.button_price_add_Click);
            // 
            // dataGridView_classes
            // 
            this.dataGridView_classes.AutoGenerateColumns = false;
            this.dataGridView_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView_classes.DataSource = this.classesBindingSource;
            this.dataGridView_classes.Location = new System.Drawing.Point(1268, 205);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.Size = new System.Drawing.Size(247, 26);
            this.dataGridView_classes.TabIndex = 54;
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
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // dataGridView_departures
            // 
            this.dataGridView_departures.AutoGenerateColumns = false;
            this.dataGridView_departures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.iDAircraftDataGridViewTextBoxColumn,
            this.iDFlightDataGridViewTextBoxColumn,
            this.iDPilotDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn});
            this.dataGridView_departures.DataSource = this.departuresBindingSource;
            this.dataGridView_departures.Location = new System.Drawing.Point(1268, 237);
            this.dataGridView_departures.Name = "dataGridView_departures";
            this.dataGridView_departures.Size = new System.Drawing.Size(247, 34);
            this.dataGridView_departures.TabIndex = 55;
            this.dataGridView_departures.Visible = false;
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
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // iDAircraftDataGridViewTextBoxColumn
            // 
            this.iDAircraftDataGridViewTextBoxColumn.DataPropertyName = "ID_Aircraft";
            this.iDAircraftDataGridViewTextBoxColumn.HeaderText = "ID_Aircraft";
            this.iDAircraftDataGridViewTextBoxColumn.Name = "iDAircraftDataGridViewTextBoxColumn";
            // 
            // iDFlightDataGridViewTextBoxColumn
            // 
            this.iDFlightDataGridViewTextBoxColumn.DataPropertyName = "ID_Flight";
            this.iDFlightDataGridViewTextBoxColumn.HeaderText = "ID_Flight";
            this.iDFlightDataGridViewTextBoxColumn.Name = "iDFlightDataGridViewTextBoxColumn";
            // 
            // iDPilotDataGridViewTextBoxColumn
            // 
            this.iDPilotDataGridViewTextBoxColumn.DataPropertyName = "ID_Pilot";
            this.iDPilotDataGridViewTextBoxColumn.HeaderText = "ID_Pilot";
            this.iDPilotDataGridViewTextBoxColumn.Name = "iDPilotDataGridViewTextBoxColumn";
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
            // Form_Clients_Tickets_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1538, 585);
            this.Controls.Add(this.dataGridView_departures);
            this.Controls.Add(this.dataGridView_classes);
            this.Controls.Add(this.button_price_delete);
            this.Controls.Add(this.button_price_change);
            this.Controls.Add(this.button_price_add);
            this.Controls.Add(this.dataGridView_prices);
            this.Controls.Add(this.dataGridView_tickets);
            this.Controls.Add(this.comboBox_price_departure);
            this.Controls.Add(this.comboBox_price_class);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_price_price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_price_id);
            this.Controls.Add(this.button_ticket_delete);
            this.Controls.Add(this.button_ticket_change);
            this.Controls.Add(this.button_ticket_add);
            this.Controls.Add(this.comboBox_ticket_client);
            this.Controls.Add(this.comboBox_ticket_price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_ticket_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ticket_seat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_ticket_id);
            this.Controls.Add(this.dataGridView_clients);
            this.Controls.Add(this.button_delete_client);
            this.Controls.Add(this.button_change_client);
            this.Controls.Add(this.button_add_client);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_idPassport_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_surname_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name_client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ID_client);
            this.Name = "Form_Clients_Tickets_Prices";
            this.Text = "Form_Clients_Tickets_Prices";
            this.Load += new System.EventHandler(this.Form_Clients_Tickets_Prices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.Button button_delete_client;
        private System.Windows.Forms.Button button_change_client;
        private System.Windows.Forms.Button button_add_client;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_idPassport_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_surname_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID_client;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private AirportDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ticket_seat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ticket_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ticket_price;
        private System.Windows.Forms.ComboBox comboBox_ticket_price;
        private System.Windows.Forms.ComboBox comboBox_ticket_client;
        private System.Windows.Forms.Button button_ticket_delete;
        private System.Windows.Forms.Button button_ticket_change;
        private System.Windows.Forms.Button button_ticket_add;
        private System.Windows.Forms.ComboBox comboBox_price_departure;
        private System.Windows.Forms.ComboBox comboBox_price_class;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_price_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_price_id;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_price_delete;
        private System.Windows.Forms.Button button_price_change;
        private System.Windows.Forms.Button button_price_add;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private AirportDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView_departures;
        private System.Windows.Forms.BindingSource departuresBindingSource;
        private AirportDataSetTableAdapters.DeparturesTableAdapter departuresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAircraftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPilotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
    }
}