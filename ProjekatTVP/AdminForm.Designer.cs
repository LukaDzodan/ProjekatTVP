namespace ProjekatTVP
{
    partial class AdminForm
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
            System.Windows.Forms.Button btnBack;
            this.lbClients = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lbReservations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnDeleteDestination = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAdmins = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Image = global::ProjekatTVP.Properties.Resources.icons8_login_80;
            btnBack.Location = new System.Drawing.Point(146, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(57, 68);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lbClients
            // 
            this.lbClients.BackColor = System.Drawing.Color.GhostWhite;
            this.lbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.HorizontalScrollbar = true;
            this.lbClients.ItemHeight = 16;
            this.lbClients.Location = new System.Drawing.Point(254, 65);
            this.lbClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(207, 148);
            this.lbClients.TabIndex = 3;
            this.lbClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbClients_MouseDoubleClick);
            // 
            // lbDestinations
            // 
            this.lbDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.HorizontalScrollbar = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(519, 65);
            this.lbDestinations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(418, 148);
            this.lbDestinations.TabIndex = 4;
            this.lbDestinations.SelectedIndexChanged += new System.EventHandler(this.lbDestinations_SelectedIndexChanged);
            this.lbDestinations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDestinations_MouseDoubleClick);
            // 
            // lbReservations
            // 
            this.lbReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservations.FormattingEnabled = true;
            this.lbReservations.HorizontalScrollbar = true;
            this.lbReservations.ItemHeight = 16;
            this.lbReservations.Location = new System.Drawing.Point(519, 289);
            this.lbReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReservations.Name = "lbReservations";
            this.lbReservations.Size = new System.Drawing.Size(418, 148);
            this.lbReservations.TabIndex = 5;
            this.lbReservations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbReservations_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(306, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(645, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destinations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(645, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnAddReservation);
            this.panel1.Controls.Add(this.btnDeleteReservation);
            this.panel1.Controls.Add(this.btnDeleteDestination);
            this.panel1.Controls.Add(this.btnAddDestination);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 462);
            this.panel1.TabIndex = 9;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(18, 280);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(185, 39);
            this.btnAddReservation.TabIndex = 14;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(18, 326);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(185, 39);
            this.btnDeleteReservation.TabIndex = 13;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnDeleteDestination
            // 
            this.btnDeleteDestination.Location = new System.Drawing.Point(18, 235);
            this.btnDeleteDestination.Name = "btnDeleteDestination";
            this.btnDeleteDestination.Size = new System.Drawing.Size(185, 39);
            this.btnDeleteDestination.TabIndex = 12;
            this.btnDeleteDestination.Text = "Delete Destination";
            this.btnDeleteDestination.UseVisualStyleBackColor = true;
            this.btnDeleteDestination.Click += new System.EventHandler(this.btnDeleteDestination_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(18, 192);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(185, 39);
            this.btnAddDestination.TabIndex = 11;
            this.btnAddDestination.Text = "Add Destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(80, 165);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 24);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = global::ProjekatTVP.Properties.Resources.adminIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(301, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Admins";
            // 
            // lbAdmins
            // 
            this.lbAdmins.BackColor = System.Drawing.Color.GhostWhite;
            this.lbAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmins.FormattingEnabled = true;
            this.lbAdmins.HorizontalScrollbar = true;
            this.lbAdmins.ItemHeight = 16;
            this.lbAdmins.Location = new System.Drawing.Point(254, 289);
            this.lbAdmins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdmins.Name = "lbAdmins";
            this.lbAdmins.Size = new System.Drawing.Size(207, 148);
            this.lbAdmins.TabIndex = 11;
            this.lbAdmins.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAdmins_MouseDoubleClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(18, 371);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(122, 32);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 462);
            this.Controls.Add(this.lbAdmins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReservations);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.ListBox lbReservations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAdmins;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnDeleteDestination;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnAddUser;
    }
}