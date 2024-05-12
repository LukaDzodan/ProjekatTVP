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
    public partial class AddReservationForm : Form
    {
        private List<Destination> destinations;
        private List<Reservation> reservations;
        private List<Reservation> clientsReservation;
        private Client client;
        public AddReservationForm(Client client, List<Reservation> clientReservation)
        {
            InitializeComponent();
            this.client = client;
            this.clientsReservation = clientReservation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(client);
            this.Hide();
            clientForm.Show();
        }

        private void AddReservationForm_Load(object sender, EventArgs e)
        {
            destinations = Destination.getDestinations();
            lbDestinations.DataSource = destinations;

            reservations = Reservation.getReservations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Destination selecteDestination = (Destination)lbDestinations.SelectedItem;
            int numberOfReservedPlaces = int.Parse(textBox1.Text);

            float discountNumber = checkDiscount(selecteDestination.Discount);
            float discount = ((float)numberOfReservedPlaces * (float)selecteDestination.Price) * discountNumber;
            int totalPrice;
            if(discountNumber > 0)
            {
                 totalPrice = (numberOfReservedPlaces * selecteDestination.Price) - (int)discount;
            }
            else
            {
                 totalPrice = (numberOfReservedPlaces * selecteDestination.Price);
            }
            
            //MessageBox.Show(discountNumber.ToString()+" " + discount +" " +totalPrice.ToString());
            
            bool continuee = true;
            foreach(Reservation r in clientsReservation)
            {
                if(r.TimeOfDeparture.Year == selecteDestination.Date.Year && r.TimeOfDeparture.Month == selecteDestination.Date.Month && r.TimeOfDeparture.Day == selecteDestination.Date.Day)
                {
                    MessageBox.Show("Vec imate rezeraciju na taj dan!");
                    continuee = false;
                }
            }

            if (continuee)
            {
                if (selecteDestination.TotalPlaces < numberOfReservedPlaces)
                {
                    MessageBox.Show("Oznacena destinacija nema toliko mesta!");
                }
                else
                {
                    Reservation reservation = new Reservation(client.ID1, selecteDestination.ID1, totalPrice, numberOfReservedPlaces,selecteDestination.Date);
                    reservations.Add(reservation);
                    

                    bool again = true;
                    foreach(Reservation r in reservations)
                    {
                        r.putReservation(r,again);
                        again = false;
                    }

                    MessageBox.Show("Uspesna rezervacija!");

                    foreach(Destination d in destinations)
                    {
                        if(d == selecteDestination)
                        {
                            d.TotalPlaces = d.TotalPlaces - numberOfReservedPlaces;
                        }
                    }

                    //List<Destination> newDestinations = new List<Destination>();
                    //foreach(Destination d in destinations)
                    //{
                    //    if(d.TotalPlaces != 0)
                    //    {
                    //        newDestinations.Add(d);
                    //    }
                    //}

                    again = true;
                    foreach (Destination d in destinations)
                    {
                        d.putDestination(d, again);
                        again = false;
                    }


                    ClientForm clientForm = new ClientForm(client);
                    this.Hide();
                    clientForm.Show();
                }
            }
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            List<Destination> destinationsToShow = new List<Destination>();
            string filter = txtFilter.Text;

            foreach(Destination d in destinations)
            {
                if (d.Location.Contains(filter))
                {
                    destinationsToShow.Add(d);
                }
            }

            lbDestinations.DataSource = null;
            lbDestinations.DataSource = destinationsToShow;
        }
    }
}
