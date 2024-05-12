using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class ChangeDestinationForm : Form
    {
        List<string> SerbianCitys = new List<string>() { "Beograd", "Novi Sad" };
        List<string> MontenegroCitys = new List<string>() { "Budva", "Herceg Novi" };
        List<string> SpanisCitys = new List<string>() { "Madrid", "Barcelona" };
        List<string> GermanyCitys = new List<string>() { "Minhen", "Berlin" };
        List<string> ItalianCitys = new List<string>() { "Rim", "Milano" };

        private Admin loginAdmin;
        private Destination destination;

        private List<Reservation> reservations;
        private List<Destination> destinations;
        public ChangeDestinationForm(Destination destination, Admin loginAdmin)
        {
            InitializeComponent();
            this.destination = destination;
            this.loginAdmin = loginAdmin;
        }

        private void ChangeDestinationForm_Load(object sender, EventArgs e)
        {
            reservations = Reservation.getReservations();
            destinations = Destination.getDestinations();


            lbldestination.Text = destination.ToString();
            cbCountrys.SelectedItem = destination.Country;
            checkLocation(destination.Country);
            txtNumberOfDays.Text = destination.DaysNumber.ToString();
            txtTotalPlaces.Text = destination.TotalPlaces.ToString();
            txtPrice.Text = destination.Price.ToString();
            cbDiscount.SelectedItem = destination.Discount.ToString();
            dateTimePicker1.Value = destination.Date;
        }

        private void checkLocation(string Country)
        {
            if (cbCountrys.Text == "Srbija")
            {
                cbLocations.DataSource = SerbianCitys;
            }
            if (cbCountrys.Text == "Montenegro")
            {
                cbLocations.DataSource = MontenegroCitys;
            }
            if (cbCountrys.Text == "Spanija")
            {
                cbLocations.DataSource = SpanisCitys;
            }
            if (cbCountrys.Text == "Nemacka")
            {
                cbLocations.DataSource = GermanyCitys;
            }
            if (cbCountrys.Text == "Italija")
            {
                cbLocations.DataSource = ItalianCitys;
            }
        }

        private void cbCountrys_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkLocation(cbCountrys.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(loginAdmin);
            this.Hide();
            adminForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int reservedPlaces = 0;
            foreach(Reservation r in reservations)
            {
                if(r.DestinationId == destination.ID1)
                {
                    reservedPlaces += r.NumberOfReservedPlaces;
                }
            }

            if (checkScopes())
            {
                if(int.Parse(txtTotalPlaces.Text) >= reservedPlaces && dateTimePicker1.Value > DateTime.Now)
                {
                    destination.Country = cbCountrys.SelectedItem.ToString();
                    destination.Location = cbLocations.SelectedItem.ToString();
                    destination.Date = dateTimePicker1.Value;
                    destination.DaysNumber = int.Parse(txtNumberOfDays.Text);
                    destination.TotalPlaces = int.Parse(txtTotalPlaces.Text) - reservedPlaces;
                    destination.Price = int.Parse(txtPrice.Text);
                    destination.Discount = cbDiscount.SelectedItem.ToString();

                    string discountStr = cbDiscount.SelectedItem.ToString();
                    float discountNumber;
                    if(discountStr == "Null")
                    {
                        discountNumber = 0.00f;
                    }
                    else
                    {
                        string[] split = discountStr.Split('%');
                        string number = split[0];

                         discountNumber = float.Parse(number) / 100;
                    }
                    //destination.Discount = cbDiscount.SelectedItem.ToString();

                    for (int i = 0; i < reservations.Count; i++)
                    {
                        if (reservations[i].DestinationId == destination.ID1)
                        {
                            float discount;
                            if(discountNumber > 0)
                            {
                                 discount = ((float)reservations[i].NumberOfReservedPlaces * (float)destination.Price) * discountNumber;
                            }
                            else
                            {
                                 discount = ((float)reservations[i].NumberOfReservedPlaces * (float)destination.Price) * 1;
                            }
                            
                            if (discountNumber > 0)
                            {
                                reservations[i].TotalPrice = (reservations[i].NumberOfReservedPlaces * destination.Price) - (int)discount;
                            }
                            else
                            {
                                reservations[i].TotalPrice = (reservations[i].NumberOfReservedPlaces * destination.Price);
                            }

                            reservations[i].TimeOfDeparture = destination.Date;
                        }
                    }

                    for (int i = 0; i < destinations.Count; i++)
                    {
                        if(destinations[i].ID1 == destination.ID1)
                        {
                            destinations[i] = destination;
                        }
                    }

                    bool again = true;
                    foreach(Reservation r in reservations)
                    {
                        r.putReservation(r, again);
                        again = false;
                    }

                    again = true;
                    foreach(Destination d in destinations)
                    {
                        d.putDestination(d,again);
                        again = false;
                    }
                    MessageBox.Show("Uspesna izmena destinacije!");
                }
                else
                {
                    MessageBox.Show("Broj mesta je suvise malo ili vam je datum zastareo!");
                }
            }
        }

        private bool checkScopes()
        {
            if (cbCountrys.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali zemlju!");
                return false;
            }
            if (cbLocations.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali mesto!");
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Niste upisali cenu!");
                return false;
            }
            if (txtNumberOfDays.Text == "")
            {
                MessageBox.Show("Niste upisali broj dana!");
                return false;
            }
            if (txtTotalPlaces.Text == "")
            {
                MessageBox.Show("Niste upisali broj mesta!");
                return false;
            }
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Los datum ste izabrali!");
                return false;
            }
            return true;
        }
    }
}
