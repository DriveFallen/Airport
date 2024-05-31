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
            this.airportDataSet = new Airport.AirportDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Airport.AirportDataSetTableAdapters.ClientsTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoGenerateColumns = false;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Surname,
            this.Passport});
            this.dataGridView_clients.DataSource = this.clientsBindingSource;
            this.dataGridView_clients.Location = new System.Drawing.Point(16, 163);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(803, 296);
            this.dataGridView_clients.TabIndex = 25;
            // 
            // button_delete_client
            // 
            this.button_delete_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete_client.Location = new System.Drawing.Point(570, 106);
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
            this.button_change_client.Location = new System.Drawing.Point(570, 71);
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
            this.button_add_client.Location = new System.Drawing.Point(570, 36);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID passport";
            // 
            // textBox_idPassport_client
            // 
            this.textBox_idPassport_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_idPassport_client.Location = new System.Drawing.Point(292, 95);
            this.textBox_idPassport_client.Name = "textBox_idPassport_client";
            this.textBox_idPassport_client.Size = new System.Drawing.Size(221, 29);
            this.textBox_idPassport_client.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(288, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Surname";
            // 
            // textBox_surname_client
            // 
            this.textBox_surname_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname_client.Location = new System.Drawing.Point(292, 36);
            this.textBox_surname_client.Name = "textBox_surname_client";
            this.textBox_surname_client.Size = new System.Drawing.Size(221, 29);
            this.textBox_surname_client.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // textBox_name_client
            // 
            this.textBox_name_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_client.Location = new System.Drawing.Point(16, 95);
            this.textBox_name_client.Name = "textBox_name_client";
            this.textBox_name_client.Size = new System.Drawing.Size(221, 29);
            this.textBox_name_client.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // textBox_ID_client
            // 
            this.textBox_ID_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ID_client.Location = new System.Drawing.Point(16, 36);
            this.textBox_ID_client.Name = "textBox_ID_client";
            this.textBox_ID_client.Size = new System.Drawing.Size(221, 29);
            this.textBox_ID_client.TabIndex = 13;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Passport
            // 
            this.Passport.DataPropertyName = "Passport";
            this.Passport.HeaderText = "Passport";
            this.Passport.Name = "Passport";
            // 
            // Form_Clients_Tickets_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1538, 670);
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
            this.Text = "Form_Clients_Tickets_Prices";
            this.Load += new System.EventHandler(this.Form_Clients_Tickets_Prices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
    }
}