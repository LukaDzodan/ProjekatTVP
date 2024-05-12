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
    public partial class AdminForm : Form
    {
        List<Client> clients;
        List<Admin> admins;
        List<Destination> destinations;
        List<Reservation> reservations;

        private Admin loginAdmin;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.loginAdmin = admin;
        }

        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = loginAdmin.UserName;
            //destinations.Clear();
            destinations = Destination.getDestinations();
            reservations = Reservation.getReservations();

            clients = Client.getClients();
            admins = Admin.getAdmins();

            if (admins.Count != 0)
            {
                lbAdmins.Items.Clear();
                lbAdmins.DataSource = admins;
            }
            else
            {
                lbAdmins.Items.Clear();
                lbAdmins.Items.Add("Ne postoje admini");
            }

            if (clients.Count != 0)
            {
                lbClients.Items.Clear();
                lbClients.DataSource = clients;
            }
            else
            {
                lbClients.Items.Clear();
                lbClients.Items.Add("Ne postoje klijenti");
            }

            if (destinations.Count != 0)
            {
                //lbDestinations.Items.Clear();
                lbDestinations.DataSource = destinations;
            }
            else
            {
                //lbDestinations.Items.Clear();
                lbDestinations.Items.Add("Ne postoje destinacije");
            }

            if (reservations.Count != 0)
            {
                lbReservations.Items.Clear();
                lbReservations.DataSource = reservations;
            }
            else
            {
                lbReservations.Items.Clear();
                lbReservations.Items.Add("Ne postoje rezervacije");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Nista
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddDestinationForm addDestinationForm = new AddDestinationForm(loginAdmin);
            this.Hide();
            addDestinationForm.Show();
        }

        private void lbClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lbClients.Items[0] == "Ne postoje klijenti")
            {
                MessageBox.Show("Ne postoji ni jedan klijent!");
            }
            else
            { 
                Client c = (Client)lbClients.SelectedItem;
                //MessageBox.Show(c.ID1 + c.Password + c.Pristup + c.UserName);
                ChangeInfoForm changeInfoForm = new ChangeInfoForm(loginAdmin, c, lbClients);
                this.Hide();
                changeInfoForm.Show();
            }
        }

        private void lbAdmins_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lbAdmins.Items[0] == "Ne postoje admini")
            {
                MessageBox.Show("Ne mozete obrisati poslednjeg admina!");
            }
            else
            {
                Admin a = (Admin)lbAdmins.SelectedItem;
                ChangeInfoForm changeInfoForm = new ChangeInfoForm(loginAdmin, a, lbAdmins);
                this.Hide();
                changeInfoForm.Show();
            }
            
        }

        private void btnDeleteDestination_Click(object sender, EventArgs e)
        {
            if(lbDestinations.Items.Count > 0)
            {
                reservations = Reservation.getReservations();
                Destination selectedDestination = (Destination)lbDestinations.SelectedItem;
                bool yes = true;
                foreach (Reservation r in reservations)
                {
                    if (r.DestinationId == selectedDestination.ID1)
                    {
                        yes = false;
                    }
                }
                if (yes)
                {
                    if (lbDestinations.Items.Count != 1)
                    {
                        destinations.Remove(selectedDestination);

                        bool again = true;
                        foreach (Destination d in destinations)
                        {
                            d.putDestination(d, again);
                            again = false;
                        }

                        destinations = Destination.getDestinations();
                        lbDestinations.DataSource = destinations;

                        MessageBox.Show("Uspesno ste obrisali destinaciju");
                    }
                    else
                    {
                        destinations.Remove(selectedDestination);
                        string toFile = "C:/Users/dzoni/source/repos/ProjekatTVP/ProjekatTVP/bin/Debug/Destinations.bin";

                        bool again = true;
                        foreach (Destination d in destinations)
                        {
                            d.putDestination(d, again);
                            again = false;
                        }
                        lbDestinations.DataSource = null;
                        File.WriteAllBytes(toFile, new byte[0]);

                        MessageBox.Show("Uspesno ste obrisali destinaciju");
                    }
                }
                else
                {
                    MessageBox.Show("Destinacija ima rezervaciju");
                }
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedna destinacija");
            }
            
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if(lbReservations.Items.Count > 0)
            {
                Reservation selectedReservation = (Reservation)lbReservations.SelectedItem;

                if (lbReservations.Items.Count != 1)
                {
                    reservations.Remove(selectedReservation);

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
                    string toFile = "C:/Users/dzoni/source/repos/ProjekatTVP/ProjekatTVP/bin/Debug/Reservations.bin";

                    bool again = true;
                    foreach (Reservation r in reservations)
                    {
                        r.putReservation(r, again);
                        again = false;
                    }

                    lbReservations.DataSource = null;
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

        private void lbDestinations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbDestinations.DataSource == "Ne postoje destinacije")
            {
                Destination destination = (Destination)lbDestinations.SelectedItem;
                ChangeDestinationForm changeDestinationForm = new ChangeDestinationForm(destination, loginAdmin);
                this.Hide();
                changeDestinationForm.Show();
            }
            else
            {
                MessageBox.Show("Za sad ne postoji ni jedna destinacija!");
            }
        }

        private void lbDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nista
        }

        private void lbReservations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbReservations.DataSource == "Ne postoje rezervacije")
            {
                Reservation reservation = (Reservation)lbReservations.SelectedItem;
                ChangeReservationAdmin changeReservationAdmin = new ChangeReservationAdmin(loginAdmin, reservation);
                this.Hide();
                changeReservationAdmin.Show();
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedna rezervacija");
            }

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if(destinations.Count > 0)
            {
                AddReservationAdmin addReservationAdmin = new AddReservationAdmin(loginAdmin);
                this.Hide();
                addReservationAdmin.Show();
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedna destinacija za sada");
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateAccForm createAccForm = new CreateAccForm(loginAdmin);
            this.Hide();
            createAccForm.Show();
        }
    }
}
