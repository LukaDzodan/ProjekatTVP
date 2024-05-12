using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class ClientForm : Form
    {
        private Client loginClient;
        List<Reservation> reservations;
        //List<Reservation> allReservations;
        List<Reservation> clientReservations = new List<Reservation>();
        List<Destination> destinations;
        public ClientForm(Client client)
        {
            InitializeComponent();
            this.loginClient = client;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = loginClient.UserName;

            reservations = Reservation.getReservations();
            //allReservations = Reservation.getAllReservations();
            destinations = Destination.getDestinations();

            if(reservations.Count != 0)
            {
                lbReservations.Items.Clear();
                foreach(Reservation r in reservations)
                {
                    if(r.UserId == loginClient.ID1)
                    {
                        clientReservations.Add(r);
                    }
                }
                lbReservations.DataSource = clientReservations;
            }
            else
            {
                lbReservations.Items.Clear();
                lbReservations.Items.Add("Ne postoje rezervacije");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if(destinations.Count > 0)
            {
                AddReservationForm addReservationForm = new AddReservationForm(loginClient, clientReservations);
                this.Hide();
                addReservationForm.Show();
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedna destinacija za sada!");
            }
        }

        private void lbReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation reservation = (Reservation)lbReservations.SelectedItem;
            foreach(Destination d in destinations)
            {
                if(d.ID1 == reservation.DestinationId)
                {
                    lblCountry.Text = d.Country;
                    lblLoaction.Text = d.Location;
                }
            }

            lblTotalPrica.Text = reservation.TotalPrice.ToString()+"e";
            lblNumOfResPlaces.Text = reservation.NumberOfReservedPlaces.ToString();
            lblReservationTime.Text = reservation.ReservationTime.ToString();
            lblTimeofDeparture.Text = reservation.TimeOfDeparture.ToString();
        }

        private void lbReservations_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearchReservations_Click(object sender, EventArgs e)
        {
            List<Reservation> listSearchReservations = new List<Reservation>();
            if(dtpFrom.Value < dtpTo.Value)
            {
                foreach (Reservation r in reservations)
                {
                    if (r.TimeOfDeparture >= dtpFrom.Value && r.TimeOfDeparture <= dtpTo.Value)
                    {
                        listSearchReservations.Add(r);
                    }
                }

                //lbReservations.DataSource = null;
                lbReservations.DataSource = listSearchReservations;
            }
            else
            {
                MessageBox.Show("Pocetni datum mora biti pre krajnjeg!");
            }
            
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (clientReservations.Count > 0)
            {
                Reservation selectedReservation = (Reservation)lbReservations.SelectedItem;

                if (lbReservations.Items.Count != 1)
                {
                    reservations.Remove(selectedReservation);
                    clientReservations.Remove(selectedReservation);

                    bool again = true;
                    foreach (Reservation r in reservations)
                    {
                        r.putReservation(r, again);
                        again = false;
                    }

                    reservations = Reservation.getReservations();
                    lbReservations.DataSource = reservations;

                    foreach (Destination d in destinations)
                    {
                        if (d.ID1 == selectedReservation.DestinationId)
                        {
                            d.TotalPlaces += selectedReservation.NumberOfReservedPlaces;
                        }
                    }

                    again = true;
                    foreach (Destination d in destinations)
                    {
                        d.putDestination(d, again);
                        again = false;
                    }

                    MessageBox.Show("Uspesno ste obrisali rezervaciju");
                }
                else
                {
                    reservations.Remove(selectedReservation);
                    clientReservations.Remove(selectedReservation);
                    string toFile = "C:/Users/dzoni/source/repos/ProjekatTVP/ProjekatTVP/bin/Debug/Reservations.bin";

                    bool again = true;
                    foreach (Reservation r in reservations)
                    {
                        r.putReservation(r, again);
                        again = false;
                    }

                    lbReservations.DataSource = null;
                    lbReservations.Refresh();

                    File.WriteAllBytes(toFile, new byte[0]);

                    foreach (Destination d in destinations)
                    {
                        if (d.ID1 == selectedReservation.DestinationId)
                        {
                            d.TotalPlaces += selectedReservation.NumberOfReservedPlaces;
                        }
                    }

                    again = true;
                    foreach (Destination d in destinations)
                    {
                        d.putDestination(d, again);
                        again = false;
                    }

                    MessageBox.Show("Uspesno ste obrisali rezervaciju");
                }
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedna rezervacija");
            }
            
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            if (lbReservations.Items.Count > 0)
            {
                MessageBox.Show("Ne postoji ni jedna rezervacija");
            }
            else
            {
                Reservation reservation = (Reservation)lbReservations.SelectedItem;
                ChangeReservasionForm changeReservasionForm = new ChangeReservasionForm(reservation, loginClient);
                this.Hide();
                changeReservasionForm.Show();
            }
        }
    }
}

