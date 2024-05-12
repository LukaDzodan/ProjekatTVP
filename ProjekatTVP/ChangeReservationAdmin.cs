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
    public partial class ChangeReservationAdmin : Form
    {
        private List<Destination> destinations;
        private List<Reservation> reservations;
        private List<Client> clients;
        private Reservation reservation;
        private Admin loginAdmin;
        public ChangeReservationAdmin(Admin loginAdmin,Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            this.loginAdmin = loginAdmin;
        }

        private void ChangeReservationAdmin_Load(object sender, EventArgs e)
        {
            destinations = Destination.getDestinations();
            clients = Client.getClients();
            reservations = Reservation.getReservations();

            lblReservation.Text = reservation.ToString();
            txtNumberOf.Text = reservation.NumberOfReservedPlaces.ToString();
            foreach (Destination d in destinations)
            {
                if(d.ID1 == reservation.DestinationId)
                {
                    d.TotalPlaces += int.Parse(txtNumberOf.Text);
                }
            }
            cbDestinations.DataSource = destinations;
            foreach(Destination d in destinations)
            {
                if(d.ID1 == reservation.DestinationId)
                {
                    cbDestinations.SelectedItem = d;
                }
            }
            cbClients.DataSource = clients;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(loginAdmin);
            this.Hide();
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Destination destination = (Destination)cbDestinations.SelectedItem;
            Client client = (Client)cbClients.SelectedItem;
            int br = 0;
            if((destination.TotalPlaces) >= int.Parse(txtNumberOf.Text))
            {
                for (int i = 0; i < reservations.Count; i++)
                {
                    if (reservations[i] == reservation)
                    {
                        br = i;
                    }
                }

                reservation.NumberOfReservedPlaces = int.Parse(txtNumberOf.Text);
                reservation.DestinationId = destination.ID1;
                reservation.UserId = client.ID1;
  
                 reservations[br] = reservation;

                bool again = true;
                foreach(Reservation r in reservations)
                {
                    r.putReservation(r,again);
                    again = false;
                }

                foreach(Destination d in destinations)
                {
                    if(d.ID1 == reservation.DestinationId)
                    {
                        d.TotalPlaces -= reservation.NumberOfReservedPlaces;
                    }
                }

                again = true;
                foreach (Destination d in destinations)
                {
                    d.putDestination(d,again);
                    again = false;
                }


                MessageBox.Show("Uspesna izmena rezervacije");
            }
            else
            {
                MessageBox.Show("Nema dovoljan broj slobodnih mesta");
            }
        }
    }
}
