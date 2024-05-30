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
            this.button_clients_tickets_prices = new System.Windows.Forms.Button();
            this.button_airports_routes_flights = new System.Windows.Forms.Button();
            this.button_classes_numberOfSeats_aircrafts = new System.Windows.Forms.Button();
            this.button_departures_pilots = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_departures_pilots);
            this.Controls.Add(this.button_classes_numberOfSeats_aircrafts);
            this.Controls.Add(this.button_airports_routes_flights);
            this.Controls.Add(this.button_clients_tickets_prices);
            this.Name = "Form_Main";
            this.Text = "Просмотр";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clients_tickets_prices;
        private System.Windows.Forms.Button button_airports_routes_flights;
        private System.Windows.Forms.Button button_classes_numberOfSeats_aircrafts;
        private System.Windows.Forms.Button button_departures_pilots;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}