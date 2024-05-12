namespace ProjekatTVP
{
    partial class ClientForm
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
            System.Windows.Forms.Button button2;
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbReservations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLoaction = new System.Windows.Forms.Label();
            this.lblTotalPrica = new System.Windows.Forms.Label();
            this.lblNumOfResPlaces = new System.Windows.Forms.Label();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.lblTimeofDeparture = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchReservations = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnChangeReservation = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.LightPink;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            button2.Image = global::ProjekatTVP.Properties.Resources.icons8_login_80;
            button2.Location = new System.Drawing.Point(162, 381);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(57, 68);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 410);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 33);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Client";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(89, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName";
            // 
            // lbReservations
            // 
            this.lbReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservations.FormattingEnabled = true;
            this.lbReservations.HorizontalScrollbar = true;
            this.lbReservations.ItemHeight = 16;
            this.lbReservations.Location = new System.Drawing.Point(558, 94);
            this.lbReservations.Name = "lbReservations";
            this.lbReservations.Size = new System.Drawing.Size(368, 340);
            this.lbReservations.TabIndex = 4;
            this.lbReservations.SelectedIndexChanged += new System.EventHandler(this.lbReservations_SelectedIndexChanged);
            this.lbReservations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbReservations_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(645, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reservations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.btnChangeReservation);
            this.panel1.Controls.Add(this.btnDeleteReservation);
            this.panel1.Controls.Add(button2);
            this.panel1.Controls.Add(this.btnAddReservation);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 461);
            this.panel1.TabIndex = 6;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(28, 184);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(171, 46);
            this.btnAddReservation.TabIndex = 4;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = global::ProjekatTVP.Properties.Resources.clientIcon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(330, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(330, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(315, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(244, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of reserved places";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(283, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reservation time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Pink;
            this.label7.Location = new System.Drawing.Point(276, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time of departure";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(331, 94);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(15, 20);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "*";
            // 
            // lblLoaction
            // 
            this.lblLoaction.AutoSize = true;
            this.lblLoaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaction.Location = new System.Drawing.Point(347, 148);
            this.lblLoaction.Name = "lblLoaction";
            this.lblLoaction.Size = new System.Drawing.Size(15, 20);
            this.lblLoaction.TabIndex = 14;
            this.lblLoaction.Text = "*";
            // 
            // lblTotalPrica
            // 
            this.lblTotalPrica.AutoSize = true;
            this.lblTotalPrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrica.Location = new System.Drawing.Point(356, 205);
            this.lblTotalPrica.Name = "lblTotalPrica";
            this.lblTotalPrica.Size = new System.Drawing.Size(15, 20);
            this.lblTotalPrica.TabIndex = 15;
            this.lblTotalPrica.Text = "*";
            // 
            // lblNumOfResPlaces
            // 
            this.lblNumOfResPlaces.AutoSize = true;
            this.lblNumOfResPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfResPlaces.Location = new System.Drawing.Point(356, 271);
            this.lblNumOfResPlaces.Name = "lblNumOfResPlaces";
            this.lblNumOfResPlaces.Size = new System.Drawing.Size(15, 20);
            this.lblNumOfResPlaces.TabIndex = 16;
            this.lblNumOfResPlaces.Text = "*";
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationTime.Location = new System.Drawing.Point(316, 337);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(15, 20);
            this.lblReservationTime.TabIndex = 17;
            this.lblReservationTime.Text = "*";
            // 
            // lblTimeofDeparture
            // 
            this.lblTimeofDeparture.AutoSize = true;
            this.lblTimeofDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeofDeparture.Location = new System.Drawing.Point(316, 398);
            this.lblTimeofDeparture.Name = "lblTimeofDeparture";
            this.lblTimeofDeparture.Size = new System.Drawing.Size(15, 20);
            this.lblTimeofDeparture.TabIndex = 18;
            this.lblTimeofDeparture.Text = "*";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(608, 68);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(96, 20);
            this.dtpFrom.TabIndex = 19;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(747, 68);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(96, 20);
            this.dtpTo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(710, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "To:";
            // 
            // btnSearchReservations
            // 
            this.btnSearchReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReservations.Location = new System.Drawing.Point(849, 68);
            this.btnSearchReservations.Name = "btnSearchReservations";
            this.btnSearchReservations.Size = new System.Drawing.Size(75, 23);
            this.btnSearchReservations.TabIndex = 23;
            this.btnSearchReservations.Text = "Search";
            this.btnSearchReservations.UseVisualStyleBackColor = true;
            this.btnSearchReservations.Click += new System.EventHandler(this.btnSearchReservations_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(28, 245);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(171, 46);
            this.btnDeleteReservation.TabIndex = 19;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeReservation.Location = new System.Drawing.Point(28, 303);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Size = new System.Drawing.Size(171, 46);
            this.btnChangeReservation.TabIndex = 20;
            this.btnChangeReservation.Text = "Change Reservation";
            this.btnChangeReservation.UseVisualStyleBackColor = true;
            this.btnChangeReservation.Click += new System.EventHandler(this.btnChangeReservation_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.btnSearchReservations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTimeofDeparture);
            this.Controls.Add(this.lblReservationTime);
            this.Controls.Add(this.lblNumOfResPlaces);
            this.Controls.Add(this.lblTotalPrica);
            this.Controls.Add(this.lblLoaction);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListBox lbReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblLoaction;
        private System.Windows.Forms.Label lblTotalPrica;
        private System.Windows.Forms.Label lblNumOfResPlaces;
        private System.Windows.Forms.Label lblReservationTime;
        private System.Windows.Forms.Label lblTimeofDeparture;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchReservations;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnChangeReservation;
    }
}