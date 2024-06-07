namespace Airport.Редактирование
{
    partial class Form_Classes_NumberOfSeats_Aircrafts
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_classes_id = new System.Windows.Forms.TextBox();
            this.button_class_add = new System.Windows.Forms.Button();
            this.button_class_change = new System.Windows.Forms.Button();
            this.button_class_delete = new System.Windows.Forms.Button();
            this.button_numberofseats_add = new System.Windows.Forms.Button();
            this.button_numberofseats_change = new System.Windows.Forms.Button();
            this.button_numberofseats_delete = new System.Windows.Forms.Button();
            this.button_aircrafts_add = new System.Windows.Forms.Button();
            this.button_aircrafts_change = new System.Windows.Forms.Button();
            this.button_aircrafts_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_classes_name = new System.Windows.Forms.TextBox();
            this.textBox_aircrafts_model = new System.Windows.Forms.TextBox();
            this.textBox_aircrafts_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_aircrafts_company = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.classesTableAdapter = new Airport.AirportDataSetTableAdapters.ClassesTableAdapter();
            this.dataGridView_numberofseats = new System.Windows.Forms.DataGridView();
            this.iDAircraftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfSeatsTableAdapter = new Airport.AirportDataSetTableAdapters.NumberOfSeatsTableAdapter();
            this.dataGridView_aircrafts = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftsTableAdapter = new Airport.AirportDataSetTableAdapters.AircraftsTableAdapter();
            this.comboBox_numberOfSeats_aircraft = new System.Windows.Forms.ComboBox();
            this.comboBox_numberOfSeats_classes = new System.Windows.Forms.ComboBox();
            this.numericUpDown_aircrafts_seats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_numberOfSeats_seats = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_numberofseats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aircrafts_seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberOfSeats_seats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // textBox_classes_id
            // 
            this.textBox_classes_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_classes_id.Location = new System.Drawing.Point(16, 43);
            this.textBox_classes_id.Name = "textBox_classes_id";
            this.textBox_classes_id.Size = new System.Drawing.Size(137, 26);
            this.textBox_classes_id.TabIndex = 2;
            // 
            // button_class_add
            // 
            this.button_class_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_class_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_class_add.Location = new System.Drawing.Point(45, 154);
            this.button_class_add.Name = "button_class_add";
            this.button_class_add.Size = new System.Drawing.Size(75, 31);
            this.button_class_add.TabIndex = 5;
            this.button_class_add.Text = "button1";
            this.button_class_add.UseVisualStyleBackColor = false;
            this.button_class_add.Click += new System.EventHandler(this.button_class_add_Click);
            // 
            // button_class_change
            // 
            this.button_class_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_class_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_class_change.Location = new System.Drawing.Point(155, 154);
            this.button_class_change.Name = "button_class_change";
            this.button_class_change.Size = new System.Drawing.Size(75, 31);
            this.button_class_change.TabIndex = 6;
            this.button_class_change.Text = "button2";
            this.button_class_change.UseVisualStyleBackColor = false;
            this.button_class_change.Click += new System.EventHandler(this.button_class_change_Click);
            // 
            // button_class_delete
            // 
            this.button_class_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_class_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_class_delete.Location = new System.Drawing.Point(100, 200);
            this.button_class_delete.Name = "button_class_delete";
            this.button_class_delete.Size = new System.Drawing.Size(75, 31);
            this.button_class_delete.TabIndex = 7;
            this.button_class_delete.Text = "button3";
            this.button_class_delete.UseVisualStyleBackColor = false;
            this.button_class_delete.Click += new System.EventHandler(this.button_class_delete_Click);
            // 
            // button_numberofseats_add
            // 
            this.button_numberofseats_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_numberofseats_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_numberofseats_add.ForeColor = System.Drawing.Color.Black;
            this.button_numberofseats_add.Location = new System.Drawing.Point(286, 212);
            this.button_numberofseats_add.Name = "button_numberofseats_add";
            this.button_numberofseats_add.Size = new System.Drawing.Size(84, 31);
            this.button_numberofseats_add.TabIndex = 8;
            this.button_numberofseats_add.Text = "button4";
            this.button_numberofseats_add.UseVisualStyleBackColor = false;
            this.button_numberofseats_add.Click += new System.EventHandler(this.button_numberofseats_add_Click);
            // 
            // button_numberofseats_change
            // 
            this.button_numberofseats_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_numberofseats_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_numberofseats_change.Location = new System.Drawing.Point(397, 212);
            this.button_numberofseats_change.Name = "button_numberofseats_change";
            this.button_numberofseats_change.Size = new System.Drawing.Size(84, 31);
            this.button_numberofseats_change.TabIndex = 9;
            this.button_numberofseats_change.Text = "button5";
            this.button_numberofseats_change.UseVisualStyleBackColor = false;
            this.button_numberofseats_change.Click += new System.EventHandler(this.button_numberofseats_change_Click);
            // 
            // button_numberofseats_delete
            // 
            this.button_numberofseats_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_numberofseats_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_numberofseats_delete.Location = new System.Drawing.Point(512, 212);
            this.button_numberofseats_delete.Name = "button_numberofseats_delete";
            this.button_numberofseats_delete.Size = new System.Drawing.Size(84, 31);
            this.button_numberofseats_delete.TabIndex = 10;
            this.button_numberofseats_delete.Text = "button6";
            this.button_numberofseats_delete.UseVisualStyleBackColor = false;
            this.button_numberofseats_delete.Click += new System.EventHandler(this.button_numberofseats_delete_Click);
            // 
            // button_aircrafts_add
            // 
            this.button_aircrafts_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_aircrafts_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aircrafts_add.Location = new System.Drawing.Point(1025, 95);
            this.button_aircrafts_add.Name = "button_aircrafts_add";
            this.button_aircrafts_add.Size = new System.Drawing.Size(92, 32);
            this.button_aircrafts_add.TabIndex = 11;
            this.button_aircrafts_add.Text = "button7";
            this.button_aircrafts_add.UseVisualStyleBackColor = false;
            this.button_aircrafts_add.Click += new System.EventHandler(this.button_aircrafts_add_Click);
            // 
            // button_aircrafts_change
            // 
            this.button_aircrafts_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_aircrafts_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aircrafts_change.Location = new System.Drawing.Point(1025, 153);
            this.button_aircrafts_change.Name = "button_aircrafts_change";
            this.button_aircrafts_change.Size = new System.Drawing.Size(92, 32);
            this.button_aircrafts_change.TabIndex = 12;
            this.button_aircrafts_change.Text = "button8";
            this.button_aircrafts_change.UseVisualStyleBackColor = false;
            this.button_aircrafts_change.Click += new System.EventHandler(this.button_aircrafts_change_Click);
            // 
            // button_aircrafts_delete
            // 
            this.button_aircrafts_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_aircrafts_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aircrafts_delete.Location = new System.Drawing.Point(1025, 211);
            this.button_aircrafts_delete.Name = "button_aircrafts_delete";
            this.button_aircrafts_delete.Size = new System.Drawing.Size(92, 32);
            this.button_aircrafts_delete.TabIndex = 13;
            this.button_aircrafts_delete.Text = "button9";
            this.button_aircrafts_delete.UseVisualStyleBackColor = false;
            this.button_aircrafts_delete.Click += new System.EventHandler(this.button_aircrafts_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(316, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID самолета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(316, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Класс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(316, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество мест";
            // 
            // textBox_classes_name
            // 
            this.textBox_classes_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_classes_name.Location = new System.Drawing.Point(16, 101);
            this.textBox_classes_name.Name = "textBox_classes_name";
            this.textBox_classes_name.Size = new System.Drawing.Size(225, 26);
            this.textBox_classes_name.TabIndex = 20;
            // 
            // textBox_aircrafts_model
            // 
            this.textBox_aircrafts_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_aircrafts_model.Location = new System.Drawing.Point(736, 156);
            this.textBox_aircrafts_model.Name = "textBox_aircrafts_model";
            this.textBox_aircrafts_model.Size = new System.Drawing.Size(231, 26);
            this.textBox_aircrafts_model.TabIndex = 26;
            // 
            // textBox_aircrafts_id
            // 
            this.textBox_aircrafts_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_aircrafts_id.Location = new System.Drawing.Point(736, 37);
            this.textBox_aircrafts_id.Name = "textBox_aircrafts_id";
            this.textBox_aircrafts_id.Size = new System.Drawing.Size(154, 26);
            this.textBox_aircrafts_id.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(732, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Модель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(732, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Места";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(732, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            // 
            // textBox_aircrafts_company
            // 
            this.textBox_aircrafts_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_aircrafts_company.Location = new System.Drawing.Point(736, 214);
            this.textBox_aircrafts_company.Name = "textBox_aircrafts_company";
            this.textBox_aircrafts_company.Size = new System.Drawing.Size(231, 26);
            this.textBox_aircrafts_company.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(732, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Компания";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(1103, 8);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(77, 62);
            this.button_back.TabIndex = 31;
            this.button_back.Text = "button1";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView_classes
            // 
            this.dataGridView_classes.AutoGenerateColumns = false;
            this.dataGridView_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView_classes.DataSource = this.classesBindingSource;
            this.dataGridView_classes.Location = new System.Drawing.Point(12, 295);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.Size = new System.Drawing.Size(250, 301);
            this.dataGridView_classes.TabIndex = 32;
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
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_numberofseats
            // 
            this.dataGridView_numberofseats.AutoGenerateColumns = false;
            this.dataGridView_numberofseats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_numberofseats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAircraftDataGridViewTextBoxColumn,
            this.iDClassDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
            this.dataGridView_numberofseats.DataSource = this.numberOfSeatsBindingSource;
            this.dataGridView_numberofseats.Location = new System.Drawing.Point(268, 295);
            this.dataGridView_numberofseats.Name = "dataGridView_numberofseats";
            this.dataGridView_numberofseats.Size = new System.Drawing.Size(375, 301);
            this.dataGridView_numberofseats.TabIndex = 33;
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
            // numberOfSeatsBindingSource
            // 
            this.numberOfSeatsBindingSource.DataMember = "NumberOfSeats";
            this.numberOfSeatsBindingSource.DataSource = this.airportDataSet;
            // 
            // numberOfSeatsTableAdapter
            // 
            this.numberOfSeatsTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView_aircrafts.Location = new System.Drawing.Point(649, 295);
            this.dataGridView_aircrafts.Name = "dataGridView_aircrafts";
            this.dataGridView_aircrafts.Size = new System.Drawing.Size(532, 301);
            this.dataGridView_aircrafts.TabIndex = 34;
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
            // aircraftsBindingSource
            // 
            this.aircraftsBindingSource.DataMember = "Aircrafts";
            this.aircraftsBindingSource.DataSource = this.airportDataSet;
            // 
            // aircraftsTableAdapter
            // 
            this.aircraftsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_numberOfSeats_aircraft
            // 
            this.comboBox_numberOfSeats_aircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_numberOfSeats_aircraft.FormattingEnabled = true;
            this.comboBox_numberOfSeats_aircraft.Location = new System.Drawing.Point(320, 42);
            this.comboBox_numberOfSeats_aircraft.Name = "comboBox_numberOfSeats_aircraft";
            this.comboBox_numberOfSeats_aircraft.Size = new System.Drawing.Size(161, 28);
            this.comboBox_numberOfSeats_aircraft.TabIndex = 35;
            // 
            // comboBox_numberOfSeats_classes
            // 
            this.comboBox_numberOfSeats_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_numberOfSeats_classes.FormattingEnabled = true;
            this.comboBox_numberOfSeats_classes.Location = new System.Drawing.Point(320, 104);
            this.comboBox_numberOfSeats_classes.Name = "comboBox_numberOfSeats_classes";
            this.comboBox_numberOfSeats_classes.Size = new System.Drawing.Size(161, 28);
            this.comboBox_numberOfSeats_classes.TabIndex = 36;
            // 
            // numericUpDown_aircrafts_seats
            // 
            this.numericUpDown_aircrafts_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_aircrafts_seats.Location = new System.Drawing.Point(736, 103);
            this.numericUpDown_aircrafts_seats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_aircrafts_seats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_aircrafts_seats.Name = "numericUpDown_aircrafts_seats";
            this.numericUpDown_aircrafts_seats.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_aircrafts_seats.TabIndex = 37;
            this.numericUpDown_aircrafts_seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_numberOfSeats_seats
            // 
            this.numericUpDown_numberOfSeats_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_numberOfSeats_seats.Location = new System.Drawing.Point(320, 168);
            this.numericUpDown_numberOfSeats_seats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_numberOfSeats_seats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numberOfSeats_seats.Name = "numericUpDown_numberOfSeats_seats";
            this.numericUpDown_numberOfSeats_seats.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_numberOfSeats_seats.TabIndex = 38;
            this.numericUpDown_numberOfSeats_seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_Classes_NumberOfSeats_Aircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1192, 608);
            this.Controls.Add(this.numericUpDown_numberOfSeats_seats);
            this.Controls.Add(this.numericUpDown_aircrafts_seats);
            this.Controls.Add(this.comboBox_numberOfSeats_classes);
            this.Controls.Add(this.comboBox_numberOfSeats_aircraft);
            this.Controls.Add(this.dataGridView_aircrafts);
            this.Controls.Add(this.dataGridView_numberofseats);
            this.Controls.Add(this.dataGridView_classes);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_aircrafts_company);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_aircrafts_model);
            this.Controls.Add(this.textBox_aircrafts_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_classes_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_aircrafts_delete);
            this.Controls.Add(this.button_aircrafts_change);
            this.Controls.Add(this.button_aircrafts_add);
            this.Controls.Add(this.button_numberofseats_delete);
            this.Controls.Add(this.button_numberofseats_change);
            this.Controls.Add(this.button_numberofseats_add);
            this.Controls.Add(this.button_class_delete);
            this.Controls.Add(this.button_class_change);
            this.Controls.Add(this.button_class_add);
            this.Controls.Add(this.textBox_classes_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Classes_NumberOfSeats_Aircrafts";
            this.Text = "Form_Classes_NumberOfSeats_Aircrafts";
            this.Load += new System.EventHandler(this.Form_Classes_NumberOfSeats_Aircrafts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_numberofseats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aircrafts_seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberOfSeats_seats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_classes_id;
        private System.Windows.Forms.Button button_class_add;
        private System.Windows.Forms.Button button_class_change;
        private System.Windows.Forms.Button button_class_delete;
        private System.Windows.Forms.Button button_numberofseats_add;
        private System.Windows.Forms.Button button_numberofseats_change;
        private System.Windows.Forms.Button button_numberofseats_delete;
        private System.Windows.Forms.Button button_aircrafts_add;
        private System.Windows.Forms.Button button_aircrafts_change;
        private System.Windows.Forms.Button button_aircrafts_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_classes_name;
        private System.Windows.Forms.TextBox textBox_aircrafts_model;
        private System.Windows.Forms.TextBox textBox_aircrafts_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_aircrafts_company;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private AirportDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_numberofseats;
        private System.Windows.Forms.BindingSource numberOfSeatsBindingSource;
        private AirportDataSetTableAdapters.NumberOfSeatsTableAdapter numberOfSeatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAircraftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_aircrafts;
        private System.Windows.Forms.BindingSource aircraftsBindingSource;
        private AirportDataSetTableAdapters.AircraftsTableAdapter aircraftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_numberOfSeats_aircraft;
        private System.Windows.Forms.ComboBox comboBox_numberOfSeats_classes;
        private System.Windows.Forms.NumericUpDown numericUpDown_aircrafts_seats;
        private System.Windows.Forms.NumericUpDown numericUpDown_numberOfSeats_seats;
    }
}