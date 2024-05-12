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
    public partial class ChangeReservasionForm : Form
    {
        private Reservation reservation;
        private Client loginClient;
        private List<Reservation> reservations;
        private List<Destination> destinations;
        public ChangeReservasionForm(Reservation reservation, Client loginClient)
        {
            InitializeComponent();
            this.reservation = reservation;
            this.loginClient = loginClient;
        }

        private void ChangeReservasionForm_Load(object sender, EventArgs e)
        {
            lblReservation.Text = reservation.ToString();
            txtNumberOfPass.Text = reservation.NumberOfReservedPlaces.ToString();

            reservations = Reservation.getReservations();
            //destinations = Destination.getDestinations();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(loginClient);
            this.Hide();
            clientForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            destinations = Destination.getDestinations();

            Reservation tempReservation = new Reservation();
            foreach(Reservation r in reservations)
            {
                if(r.DestinationId == reservation.DestinationId)
                {
                    tempReservation = r;
                }
            }

            Destination destination = new Destination();
            foreach (Destination d in destinations)
            {
                if (d.ID1 == reservation.DestinationId)
                {
                    d.TotalPlaces += reservation.NumberOfReservedPlaces;
                    destination = d;
                }
            }

            if (int.Parse(txtNumberOfPass.Text) > destination.TotalPlaces)
            {
                MessageBox.Show("Nema toliko slobodnih mesta!");
            }
            else
            {
                foreach(Reservation r in reservations)
                {
                    if(r == tempReservation)
                    {
                        r.NumberOfReservedPlaces = int.Parse(txtNumberOfPass.Text);
                    }
                }

                bool again = true;
                foreach(Reservation r in reservations)
                {
                    r.putReservation(r, again);
                    again = false;
                }

                foreach(Destination d in destinations)
                {
                    if(d.ID1 == tempReservation.DestinationId)
                    {
                        d.TotalPlaces -= int.Parse(txtNumberOfPass.Text);
                    }
                }

                again = true;
                foreach (Destination d in destinations)
                {
                    d.putDestination(d, again);
                    again = false;
                }


                MessageBox.Show("Uspesno ste izmenili rezervaciju");

                ClientForm clientForm = new ClientForm(loginClient);
                this.Hide();
                clientForm.Show();
            }
        }
    }
}
