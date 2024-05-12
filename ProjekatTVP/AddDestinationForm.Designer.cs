namespace ProjekatTVP
{
    partial class AddDestinationForm
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
            this.lblLocatio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.cbCountrys = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDiscount30 = new System.Windows.Forms.RadioButton();
            this.rbDiscount20 = new System.Windows.Forms.RadioButton();
            this.rbDiscount15 = new System.Windows.Forms.RadioButton();
            this.rbDiscount10 = new System.Windows.Forms.RadioButton();
            this.rbDiscount5 = new System.Windows.Forms.RadioButton();
            this.rbNothing = new System.Windows.Forms.RadioButton();
            this.txtDaysNumbers = new System.Windows.Forms.TextBox();
            this.txtTotalPlaces = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.pbLocations = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = global::ProjekatTVP.Properties.Resources.icons8_login_80;
            button2.Location = new System.Drawing.Point(379, 485);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(57, 68);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLocatio
            // 
            this.lblLocatio.AutoSize = true;
            this.lblLocatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatio.Location = new System.Drawing.Point(26, 114);
            this.lblLocatio.Name = "lblLocatio";
            this.lblLocatio.Size = new System.Drawing.Size(78, 20);
            this.lblLocatio.TabIndex = 0;
            this.lblLocatio.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Days number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total places";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // cbLocations
            // 
            this.cbLocations.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cbLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(30, 137);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(122, 21);
            this.cbLocations.TabIndex = 7;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // cbCountrys
            // 
            this.cbCountrys.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cbCountrys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountrys.FormattingEnabled = true;
            this.cbCountrys.Items.AddRange(new object[] {
            "Srbija",
            "Montenegro",
            "Spanija",
            "Nemacka",
            "Italija",
            ""});
            this.cbCountrys.Location = new System.Drawing.Point(30, 71);
            this.cbCountrys.Name = "cbCountrys";
            this.cbCountrys.Size = new System.Drawing.Size(122, 21);
            this.cbCountrys.TabIndex = 8;
            this.cbCountrys.SelectedIndexChanged += new System.EventHandler(this.cbCountrys_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(80, 180);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(117, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbDiscount30);
            this.groupBox1.Controls.Add(this.rbDiscount20);
            this.groupBox1.Controls.Add(this.rbDiscount15);
            this.groupBox1.Controls.Add(this.rbDiscount10);
            this.groupBox1.Controls.Add(this.rbDiscount5);
            this.groupBox1.Controls.Add(this.rbNothing);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbDiscount30
            // 
            this.rbDiscount30.AutoSize = true;
            this.rbDiscount30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount30.Location = new System.Drawing.Point(87, 56);
            this.rbDiscount30.Name = "rbDiscount30";
            this.rbDiscount30.Size = new System.Drawing.Size(52, 20);
            this.rbDiscount30.TabIndex = 5;
            this.rbDiscount30.TabStop = true;
            this.rbDiscount30.Text = "30%";
            this.rbDiscount30.UseVisualStyleBackColor = true;
            // 
            // rbDiscount20
            // 
            this.rbDiscount20.AutoSize = true;
            this.rbDiscount20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount20.Location = new System.Drawing.Point(87, 34);
            this.rbDiscount20.Name = "rbDiscount20";
            this.rbDiscount20.Size = new System.Drawing.Size(52, 20);
            this.rbDiscount20.TabIndex = 4;
            this.rbDiscount20.TabStop = true;
            this.rbDiscount20.Text = "20%";
            this.rbDiscount20.UseVisualStyleBackColor = true;
            // 
            // rbDiscount15
            // 
            this.rbDiscount15.AutoSize = true;
            this.rbDiscount15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount15.Location = new System.Drawing.Point(87, 11);
            this.rbDiscount15.Name = "rbDiscount15";
            this.rbDiscount15.Size = new System.Drawing.Size(52, 20);
            this.rbDiscount15.TabIndex = 3;
            this.rbDiscount15.TabStop = true;
            this.rbDiscount15.Text = "15%";
            this.rbDiscount15.UseVisualStyleBackColor = true;
            // 
            // rbDiscount10
            // 
            this.rbDiscount10.AutoSize = true;
            this.rbDiscount10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount10.Location = new System.Drawing.Point(7, 57);
            this.rbDiscount10.Name = "rbDiscount10";
            this.rbDiscount10.Size = new System.Drawing.Size(52, 20);
            this.rbDiscount10.TabIndex = 2;
            this.rbDiscount10.TabStop = true;
            this.rbDiscount10.Text = "10%";
            this.rbDiscount10.UseVisualStyleBackColor = true;
            // 
            // rbDiscount5
            // 
            this.rbDiscount5.AutoSize = true;
            this.rbDiscount5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount5.Location = new System.Drawing.Point(7, 34);
            this.rbDiscount5.Name = "rbDiscount5";
            this.rbDiscount5.Size = new System.Drawing.Size(45, 20);
            this.rbDiscount5.TabIndex = 1;
            this.rbDiscount5.TabStop = true;
            this.rbDiscount5.Text = "5%";
            this.rbDiscount5.UseVisualStyleBackColor = true;
            // 
            // rbNothing
            // 
            this.rbNothing.AutoSize = true;
            this.rbNothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNothing.Location = new System.Drawing.Point(7, 11);
            this.rbNothing.Name = "rbNothing";
            this.rbNothing.Size = new System.Drawing.Size(49, 20);
            this.rbNothing.TabIndex = 0;
            this.rbNothing.TabStop = true;
            this.rbNothing.Text = "Null";
            this.rbNothing.UseVisualStyleBackColor = true;
            // 
            // txtDaysNumbers
            // 
            this.txtDaysNumbers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDaysNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysNumbers.Location = new System.Drawing.Point(146, 357);
            this.txtDaysNumbers.Name = "txtDaysNumbers";
            this.txtDaysNumbers.Size = new System.Drawing.Size(52, 20);
            this.txtDaysNumbers.TabIndex = 11;
            // 
            // txtTotalPlaces
            // 
            this.txtTotalPlaces.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTotalPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPlaces.Location = new System.Drawing.Point(146, 402);
            this.txtTotalPlaces.Name = "txtTotalPlaces";
            this.txtTotalPlaces.Size = new System.Drawing.Size(52, 20);
            this.txtTotalPlaces.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 443);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDestination.Location = new System.Drawing.Point(243, 357);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(150, 50);
            this.btnAddDestination.TabIndex = 16;
            this.btnAddDestination.Text = "Add Destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // pbCountry
            // 
            this.pbCountry.Image = global::ProjekatTVP.Properties.Resources.noImagePicture;
            this.pbCountry.Location = new System.Drawing.Point(243, 36);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(150, 122);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountry.TabIndex = 15;
            this.pbCountry.TabStop = false;
            // 
            // pbLocations
            // 
            this.pbLocations.Image = global::ProjekatTVP.Properties.Resources.noImagePicture;
            this.pbLocations.Location = new System.Drawing.Point(243, 199);
            this.pbLocations.Name = "pbLocations";
            this.pbLocations.Size = new System.Drawing.Size(150, 122);
            this.pbLocations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocations.TabIndex = 14;
            this.pbLocations.TabStop = false;
            // 
            // AddDestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(448, 565);
            this.Controls.Add(button2);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.pbCountry);
            this.Controls.Add(this.pbLocations);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTotalPlaces);
            this.Controls.Add(this.txtDaysNumbers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbCountrys);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLocatio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDestinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDestinationForm";
            this.Load += new System.EventHandler(this.AddDestinationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.ComboBox cbCountrys;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDiscount30;
        private System.Windows.Forms.RadioButton rbDiscount20;
        private System.Windows.Forms.RadioButton rbDiscount15;
        private System.Windows.Forms.RadioButton rbDiscount10;
        private System.Windows.Forms.RadioButton rbDiscount5;
        private System.Windows.Forms.RadioButton rbNothing;
        private System.Windows.Forms.TextBox txtDaysNumbers;
        private System.Windows.Forms.TextBox txtTotalPlaces;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pbLocations;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.Button btnAddDestination;
    }
}