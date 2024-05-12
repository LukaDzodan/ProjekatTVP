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
    public partial class AddReservationAdmin : Form
    {
        List<Destination> destinations;
        List<Reservation> reservations;
        List<Client> clients;
        Admin loginAdmin;
        public AddReservationAdmin(Admin loginAdmin)
        {
            InitializeComponent();
            this.loginAdmin = loginAdmin;
        }

        private void AddReservationAdmin_Load(object sender, EventArgs e)
        {
            destinations = Destination.getDestinations();
            reservations = Reservation.getReservations();
            clients = Client.getClients();

            lbDestinations.DataSource = destinations;
            comboBox1.DataSource = clients;

        }

        private float checkDiscount(string discountString)
        {
            float discount = 0;
            switch (discountString)
            {
                case "Null":
                    discount = 1;
                    break;
                case "5%":
                    discount = 0.05f;
                    break;
                case "10%":
                    discount = 0.1f;
                    break;
                case "15%":
                    discount = 0.15f;
                    break;
                case "20%":
                    discount = 0.2f;
                    break;
                case "30%":
                    discount = 0.3f;
                    break;
            }
            return discount;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(loginAdmin);
            this.Hide();
            adminForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Destination destination = (Destination)lbDestinations.SelectedItem;
            Client client = (Client)comboBox1.SelectedItem;

            bool da = true;
            foreach (Reservation r in reservations)
            {
                if (r.UserId == client.ID1 && r.DestinationId == destination.ID1)
                {
                    MessageBox.Show("Klijent vec ima rezervaciju na ovu destinaciju!");
                    da = false;
                }
                if (r.TimeOfDeparture.Year == destination.Date.Year && r.TimeOfDeparture.Month == destination.Date.Month && r.TimeOfDeparture.Day == destination.Date.Day && r.UserId == client.ID1)
                {
                    MessageBox.Show("Dati klijenat vec ima rezervaciju na taj dan!");
                    da = false;
                }
            }

            float discountNumber = checkDiscount(destination.Discount);
            float discount = (float.Parse(txtNumberOfPassenger.Text) * float.Parse(destination.Price.ToString())) * discountNumber;
            int totalPrice;
            if (discountNumber > 0)
            {
                totalPrice = (int.Parse(txtNumberOfPassenger.Text) * destination.Price) - (int)discount;
            }
            else
            {
                totalPrice = (int.Parse(txtNumberOfPassenger.Text) * destination.Price);
            }


            if (da)
            {
                if (int.Parse(txtNumberOfPassenger.Text) > 0 && int.Parse(txtNumberOfPassenger.Text) <= destination.TotalPlaces)
                {
                    Reservation reservation = new Reservation(client.ID1, destination.ID1, totalPrice, int.Parse(txtNumberOfPassenger.Text), destination.Date);
                    MessageBox.Show(reservation.ToString());
                    reservations.Add(reservation);

                    bool again = true;
                    foreach (Reservation r in reservations)
                    {
                        r.putReservation(r, again);
                        again = false;
                    }

                    MessageBox.Show("Uspesno ste dodali rezervaciju!");

                    foreach (Destination d in destinations)
                    {
                        if (d.ID1 == destination.ID1)
                        {
                            d.TotalPlaces -= int.Parse(txtNumberOfPassenger.Text);
                        }
                    }

                    again = true;
                    foreach (Destination d in destinations)
                    {
                        d.putDestination(d, again);
                        again = false;
                    }


                    AdminForm adminForm = new AdminForm(loginAdmin);
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Broj putnika nije validan!");
                }
            }

        }

    }
}



