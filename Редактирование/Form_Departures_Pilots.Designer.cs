namespace Airport.Редактирование
{
    partial class Form_Departures_Pilots
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_departures_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_departures_delete = new System.Windows.Forms.Button();
            this.button_departures_change = new System.Windows.Forms.Button();
            this.button_departures_add = new System.Windows.Forms.Button();
            this.dataGridView_departures = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAircraftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPilotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.departuresTableAdapter = new Airport.AirportDataSetTableAdapters.DeparturesTableAdapter();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_pilots_surname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_pilots_name = new System.Windows.Forms.TextBox();
            this.label_pilots_name = new System.Windows.Forms.Label();
            this.textBox_pilots_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_pilots_delete = new System.Windows.Forms.Button();
            this.button_pilots_change = new System.Windows.Forms.Button();
            this.button_pilots_add = new System.Windows.Forms.Button();
            this.dataGridView_pilots = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotsTableAdapter = new Airport.AirportDataSetTableAdapters.PilotsTableAdapter();
            this.button_back = new System.Windows.Forms.Button();
            this.comboBox_departures_aircraft = new System.Windows.Forms.ComboBox();
            this.comboBox_departures_flight = new System.Windows.Forms.ComboBox();
            this.comboBox_departures_pilot = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_departures_departure = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_departures_arrival = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_pilots_exp = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_departures_aircrafts = new System.Windows.Forms.DataGridView();
            this.dataGridView_departures_flights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pilots_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures_aircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox_departures_id
            // 
            this.textBox_departures_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_departures_id.Location = new System.Drawing.Point(29, 35);
            this.textBox_departures_id.Name = "textBox_departures_id";
            this.textBox_departures_id.Size = new System.Drawing.Size(121, 26);
            this.textBox_departures_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Самолет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рейс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пилот";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Время посадки";
            // 
            // button_departures_delete
            // 
            this.button_departures_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_departures_delete.Location = new System.Drawing.Point(379, 201);
            this.button_departures_delete.Name = "button_departures_delete";
            this.button_departures_delete.Size = new System.Drawing.Size(97, 29);
            this.button_departures_delete.TabIndex = 14;
            this.button_departures_delete.Text = "button3";
            this.button_departures_delete.UseVisualStyleBackColor = false;
            this.button_departures_delete.Click += new System.EventHandler(this.button_departures_delete_Click);
            // 
            // button_departures_change
            // 
            this.button_departures_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_departures_change.Location = new System.Drawing.Point(379, 148);
            this.button_departures_change.Name = "button_departures_change";
            this.button_departures_change.Size = new System.Drawing.Size(97, 29);
            this.button_departures_change.TabIndex = 13;
            this.button_departures_change.Text = "button2";
            this.button_departures_change.UseVisualStyleBackColor = false;
            this.button_departures_change.Click += new System.EventHandler(this.button_departures_change_Click);
            // 
            // button_departures_add
            // 
            this.button_departures_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_departures_add.Location = new System.Drawing.Point(379, 95);
            this.button_departures_add.Name = "button_departures_add";
            this.button_departures_add.Size = new System.Drawing.Size(97, 29);
            this.button_departures_add.TabIndex = 12;
            this.button_departures_add.Text = "button1";
            this.button_departures_add.UseVisualStyleBackColor = false;
            this.button_departures_add.Click += new System.EventHandler(this.button_departures_add_Click);
            // 
            // dataGridView_departures
            // 
            this.dataGridView_departures.AutoGenerateColumns = false;
            this.dataGridView_departures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDAircraftDataGridViewTextBoxColumn,
            this.iDFlightDataGridViewTextBoxColumn,
            this.iDPilotDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn});
            this.dataGridView_departures.DataSource = this.departuresBindingSource;
            this.dataGridView_departures.Location = new System.Drawing.Point(12, 358);
            this.dataGridView_departures.Name = "dataGridView_departures";
            this.dataGridView_departures.Size = new System.Drawing.Size(645, 150);
            this.dataGridView_departures.TabIndex = 15;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // departuresBindingSource
            // 
            this.departuresBindingSource.DataMember = "Departures";
            this.departuresBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departuresTableAdapter
            // 
            this.departuresTableAdapter.ClearBeforeFill = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(25, 238);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(119, 20);
            this.label.TabIndex = 16;
            this.label.Text = "Время вылета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(659, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Стаж";
            // 
            // textBox_pilots_surname
            // 
            this.textBox_pilots_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pilots_surname.Location = new System.Drawing.Point(663, 151);
            this.textBox_pilots_surname.Name = "textBox_pilots_surname";
            this.textBox_pilots_surname.Size = new System.Drawing.Size(221, 26);
            this.textBox_pilots_surname.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(659, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Фамилия";
            // 
            // textBox_pilots_name
            // 
            this.textBox_pilots_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pilots_name.Location = new System.Drawing.Point(663, 95);
            this.textBox_pilots_name.Name = "textBox_pilots_name";
            this.textBox_pilots_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_pilots_name.TabIndex = 21;
            // 
            // label_pilots_name
            // 
            this.label_pilots_name.AutoSize = true;
            this.label_pilots_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pilots_name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_pilots_name.Location = new System.Drawing.Point(659, 72);
            this.label_pilots_name.Name = "label_pilots_name";
            this.label_pilots_name.Size = new System.Drawing.Size(40, 20);
            this.label_pilots_name.TabIndex = 20;
            this.label_pilots_name.Text = "Имя";
            // 
            // textBox_pilots_id
            // 
            this.textBox_pilots_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pilots_id.Location = new System.Drawing.Point(663, 35);
            this.textBox_pilots_id.Name = "textBox_pilots_id";
            this.textBox_pilots_id.Size = new System.Drawing.Size(114, 26);
            this.textBox_pilots_id.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(659, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID";
            // 
            // button_pilots_delete
            // 
            this.button_pilots_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_pilots_delete.Location = new System.Drawing.Point(926, 234);
            this.button_pilots_delete.Name = "button_pilots_delete";
            this.button_pilots_delete.Size = new System.Drawing.Size(97, 29);
            this.button_pilots_delete.TabIndex = 28;
            this.button_pilots_delete.Text = "button3";
            this.button_pilots_delete.UseVisualStyleBackColor = false;
            this.button_pilots_delete.Click += new System.EventHandler(this.button_pilots_delete_Click);
            // 
            // button_pilots_change
            // 
            this.button_pilots_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_pilots_change.Location = new System.Drawing.Point(926, 181);
            this.button_pilots_change.Name = "button_pilots_change";
            this.button_pilots_change.Size = new System.Drawing.Size(97, 29);
            this.button_pilots_change.TabIndex = 27;
            this.button_pilots_change.Text = "button2";
            this.button_pilots_change.UseVisualStyleBackColor = false;
            this.button_pilots_change.Click += new System.EventHandler(this.button_pilots_change_Click);
            // 
            // button_pilots_add
            // 
            this.button_pilots_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_pilots_add.Location = new System.Drawing.Point(926, 128);
            this.button_pilots_add.Name = "button_pilots_add";
            this.button_pilots_add.Size = new System.Drawing.Size(97, 29);
            this.button_pilots_add.TabIndex = 26;
            this.button_pilots_add.Text = "button1";
            this.button_pilots_add.UseVisualStyleBackColor = false;
            this.button_pilots_add.Click += new System.EventHandler(this.button_pilots_add_Click);
            // 
            // dataGridView_pilots
            // 
            this.dataGridView_pilots.AutoGenerateColumns = false;
            this.dataGridView_pilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pilots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.expirienceDataGridViewTextBoxColumn});
            this.dataGridView_pilots.DataSource = this.pilotsBindingSource;
            this.dataGridView_pilots.Location = new System.Drawing.Point(663, 358);
            this.dataGridView_pilots.Name = "dataGridView_pilots";
            this.dataGridView_pilots.Size = new System.Drawing.Size(444, 150);
            this.dataGridView_pilots.TabIndex = 29;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // expirienceDataGridViewTextBoxColumn
            // 
            this.expirienceDataGridViewTextBoxColumn.DataPropertyName = "Expirience";
            this.expirienceDataGridViewTextBoxColumn.HeaderText = "Expirience";
            this.expirienceDataGridViewTextBoxColumn.Name = "expirienceDataGridViewTextBoxColumn";
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
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(1030, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(77, 61);
            this.button_back.TabIndex = 30;
            this.button_back.Text = "button3";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // comboBox_departures_aircraft
            // 
            this.comboBox_departures_aircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_departures_aircraft.FormattingEnabled = true;
            this.comboBox_departures_aircraft.Location = new System.Drawing.Point(29, 95);
            this.comboBox_departures_aircraft.Name = "comboBox_departures_aircraft";
            this.comboBox_departures_aircraft.Size = new System.Drawing.Size(148, 28);
            this.comboBox_departures_aircraft.TabIndex = 31;
            // 
            // comboBox_departures_flight
            // 
            this.comboBox_departures_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_departures_flight.FormattingEnabled = true;
            this.comboBox_departures_flight.Location = new System.Drawing.Point(29, 151);
            this.comboBox_departures_flight.Name = "comboBox_departures_flight";
            this.comboBox_departures_flight.Size = new System.Drawing.Size(148, 28);
            this.comboBox_departures_flight.TabIndex = 32;
            // 
            // comboBox_departures_pilot
            // 
            this.comboBox_departures_pilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_departures_pilot.FormattingEnabled = true;
            this.comboBox_departures_pilot.Location = new System.Drawing.Point(29, 207);
            this.comboBox_departures_pilot.Name = "comboBox_departures_pilot";
            this.comboBox_departures_pilot.Size = new System.Drawing.Size(148, 28);
            this.comboBox_departures_pilot.TabIndex = 33;
            // 
            // dateTimePicker_departures_departure
            // 
            this.dateTimePicker_departures_departure.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker_departures_departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_departures_departure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_departures_departure.Location = new System.Drawing.Point(29, 261);
            this.dateTimePicker_departures_departure.Name = "dateTimePicker_departures_departure";
            this.dateTimePicker_departures_departure.Size = new System.Drawing.Size(223, 29);
            this.dateTimePicker_departures_departure.TabIndex = 66;
            // 
            // dateTimePicker_departures_arrival
            // 
            this.dateTimePicker_departures_arrival.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker_departures_arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_departures_arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_departures_arrival.Location = new System.Drawing.Point(29, 323);
            this.dateTimePicker_departures_arrival.Name = "dateTimePicker_departures_arrival";
            this.dateTimePicker_departures_arrival.Size = new System.Drawing.Size(223, 29);
            this.dateTimePicker_departures_arrival.TabIndex = 67;
            // 
            // numericUpDown_pilots_exp
            // 
            this.numericUpDown_pilots_exp.DecimalPlaces = 1;
            this.numericUpDown_pilots_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_pilots_exp.Location = new System.Drawing.Point(663, 209);
            this.numericUpDown_pilots_exp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_pilots_exp.Name = "numericUpDown_pilots_exp";
            this.numericUpDown_pilots_exp.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_pilots_exp.TabIndex = 68;
            this.numericUpDown_pilots_exp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView_departures_aircrafts
            // 
            this.dataGridView_departures_aircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures_aircrafts.Location = new System.Drawing.Point(279, 395);
            this.dataGridView_departures_aircrafts.Name = "dataGridView_departures_aircrafts";
            this.dataGridView_departures_aircrafts.Size = new System.Drawing.Size(139, 82);
            this.dataGridView_departures_aircrafts.TabIndex = 69;
            // 
            // dataGridView_departures_flights
            // 
            this.dataGridView_departures_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departures_flights.Location = new System.Drawing.Point(424, 393);
            this.dataGridView_departures_flights.Name = "dataGridView_departures_flights";
            this.dataGridView_departures_flights.Size = new System.Drawing.Size(139, 82);
            this.dataGridView_departures_flights.TabIndex = 70;
            // 
            // Form_Departures_Pilots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1119, 523);
            this.Controls.Add(this.numericUpDown_pilots_exp);
            this.Controls.Add(this.dateTimePicker_departures_arrival);
            this.Controls.Add(this.dateTimePicker_departures_departure);
            this.Controls.Add(this.comboBox_departures_pilot);
            this.Controls.Add(this.comboBox_departures_flight);
            this.Controls.Add(this.comboBox_departures_aircraft);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView_pilots);
            this.Controls.Add(this.button_pilots_delete);
            this.Controls.Add(this.button_pilots_change);
            this.Controls.Add(this.button_pilots_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_pilots_surname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_pilots_name);
            this.Controls.Add(this.label_pilots_name);
            this.Controls.Add(this.textBox_pilots_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView_departures);
            this.Controls.Add(this.button_departures_delete);
            this.Controls.Add(this.button_departures_change);
            this.Controls.Add(this.button_departures_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_departures_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_departures_flights);
            this.Controls.Add(this.dataGridView_departures_aircrafts);
            this.Name = "Form_Departures_Pilots";
            this.Text = "Form_Departures_Pilots";
            this.Load += new System.EventHandler(this.Form_Departures_Pilots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pilots_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures_aircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departures_flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_departures_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_departures_delete;
        private System.Windows.Forms.Button button_departures_change;
        private System.Windows.Forms.Button button_departures_add;
        private System.Windows.Forms.DataGridView dataGridView_departures;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource departuresBindingSource;
        private AirportDataSetTableAdapters.DeparturesTableAdapter departuresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAircraftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPilotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_pilots_surname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_pilots_name;
        private System.Windows.Forms.Label label_pilots_name;
        private System.Windows.Forms.TextBox textBox_pilots_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_pilots_delete;
        private System.Windows.Forms.Button button_pilots_change;
        private System.Windows.Forms.Button button_pilots_add;
        private System.Windows.Forms.DataGridView dataGridView_pilots;
        private System.Windows.Forms.BindingSource pilotsBindingSource;
        private AirportDataSetTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox comboBox_departures_aircraft;
        private System.Windows.Forms.ComboBox comboBox_departures_flight;
        private System.Windows.Forms.ComboBox comboBox_departures_pilot;
        private System.Windows.Forms.DateTimePicker dateTimePicker_departures_departure;
        private System.Windows.Forms.DateTimePicker dateTimePicker_departures_arrival;
        private System.Windows.Forms.NumericUpDown numericUpDown_pilots_exp;
        private System.Windows.Forms.DataGridView dataGridView_departures_aircrafts;
        private System.Windows.Forms.DataGridView dataGridView_departures_flights;
    }
}