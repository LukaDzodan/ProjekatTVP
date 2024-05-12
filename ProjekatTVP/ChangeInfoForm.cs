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
    public partial class ChangeInfoForm : Form
    {
        private Client client;
        private Admin admin;
        private Admin adminToChange;
        List<Client> clients;
        List<Reservation> reservations;
        List<Admin> admins;
        ListBox lbClients;
        ListBox lbAdmins;
        public ChangeInfoForm(Admin admin,Admin adminToChange, ListBox lbAdmins)
        {
            InitializeComponent();
            this.admin = admin;
            this.adminToChange = adminToChange;
            this.lbAdmins = lbAdmins;
        }

        public ChangeInfoForm(Admin admin,Client client, ListBox lbClients)
        {
            InitializeComponent();
            this.admin = admin;
            this.client = client;
            this.lbClients = lbClients;
        }
        private void ChangeInfoForm_Load(object sender, EventArgs e)
        {
            if(client != null)
            {
                txtName.Text = client.Name;
                txtSurname.Text = client.Surname;
                txtUserName.Text = client.UserName;
                txtPassword.Text = client.Password;
                cbPermission.SelectedItem = client.Pristup;
            }else
            {
                txtName.Text = adminToChange.Name;
                txtSurname.Text = adminToChange.Surname;
                txtUserName.Text = adminToChange.UserName;
                txtPassword.Text = adminToChange.Password;
                cbPermission.SelectedItem = adminToChange.Pristup;
            }

            clients = Client.getClients();
            admins = Admin.getAdmins();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminFomr = new AdminForm(admin);
            this.Hide();
            adminFomr.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = 0; 

            if (client != null)
            {
                //gore adminToChange proveri
                if(cbPermission.SelectedItem.ToString() == "Admin")
                {
                    Admin newAdmin = new Admin(txtUserName.Text, txtPassword.Text,txtName.Text,txtSurname.Text);
                    admins.Add(newAdmin);

                    bool again = true;
                    foreach (Admin a in admins)
                    {
                        a.putAdmin(a, again);
                        again = false;
                    }

                    foreach(Client c in clients)
                    {
                        if(client.UserName == c.UserName)
                        {
                            break;
                        }
                        index++;
                    }

                    clients.RemoveAt(index);

                    again = true;
                    foreach (Client c in clients)
                    {
                        c.putClient(c, again);
                        again = false;
                    }
                    MessageBox.Show("Uspesno ste sacuvali korisnika!");
                }
                else
                {
                    foreach (Client c in clients)
                    {
                        if (c.UserName == client.UserName)
                        {
                            c.UserName = txtUserName.Text;
                            c.Password = txtPassword.Text;
                            c.Pristup = cbPermission.SelectedItem.ToString();
                        }
                    }

                    bool again = true;
                    foreach (Client c in clients)
                    {
                        c.putClient(c, again);
                        again = false;
                    }
                    MessageBox.Show("Uspesno ste sacuvali korisnika!");
                }
           
            }
            else
            {
                if (cbPermission.SelectedItem.ToString() == "Client")
                {
                    Client newClient = new Client(txtUserName.Text, txtPassword.Text, txtName.Text, txtSurname.Text);
                    clients.Add(newClient);

                    bool again = true;
                    foreach (Client c in clients)
                    {
                        c.putClient(c, again);
                        again = false;
                    }

                    foreach (Admin a in admins)
                    {
                        if (adminToChange.UserName == a.UserName)
                        {
                            break;
                        }
                        index++;
                    }

                    admins.RemoveAt(index);

                    again = true;
                    foreach (Admin a in admins)
                    {
                        a.putAdmin(a, again);
                        again = false;
                    }
                    MessageBox.Show("Uspesno ste sacuvali korisnika!");
                }
                else
                {
                    foreach (Admin a in admins)
                    {
                        if (a.UserName == adminToChange.UserName)
                        {
                            a.UserName = txtUserName.Text;
                            a.Password = txtPassword.Text;
                            a.Pristup = cbPermission.SelectedItem.ToString();
                        }
                    }

                    bool again = true;
                    foreach (Admin a in admins)
                    {
                        a.putAdmin(a, again);
                        again = false;
                    }

                    MessageBox.Show("Uspesno ste sacuvali korisnika!");
                }
            }


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            clients = Client.getClients();
            admins = Admin.getAdmins();

            reservations = Reservation.getReservations();

            Client clientToDelete = new Client();
            if (client != null)
            {
                bool da = true;
                foreach (Reservation r in reservations)
                {
                    if (r.UserId == client.ID1)
                    {
                        da = false;
                    }
                }
                if (da)
                {
                    if (lbClients.Items.Count != 1)
                    {
                        foreach (Client c in clients)
                        {
                            if (c.UserName == client.UserName)
                            {
                                clientToDelete = c;
                            }
                        }

                        clients.Remove(clientToDelete);
                        //MessageBox.Show(client.ID1 + client.Password + client.Pristup + client.UserName);

                        bool again = true;
                        foreach (Client c in clients)
                        {
                            c.putClient(c, again);
                            again = false;
                        }

                        MessageBox.Show("Uspesno ste obrisali korisnika!");

                        //clients = Client.getClients();
                        //lbClients.DataSource = clients;
                    }
                    else
                    {
                        clients.Remove(client);
                        string toFile = "C:/Users/dzoni/source/repos/ProjekatTVP/ProjekatTVP/bin/Debug/Clients.bin";

                        bool again = true;
                        foreach (Client c in clients)
                        {
                            c.putClient(c, again);
                            again = false;
                        }
                        //lbClients.DataSource = null;
                        File.WriteAllBytes(toFile, new byte[0]);
                        MessageBox.Show("Uspesno ste obrisali korisnika!");
                    }
                }
                else
                {
                    MessageBox.Show("Dati klijent ima rezervaciju");
                }
            }
            else
            {
                Admin adminToDelete = new Admin();

                if (lbAdmins.Items.Count != 1)
                {
                    foreach(Admin a in admins)
                    {
                        if(a.UserName == adminToChange.UserName)
                        {
                            adminToDelete = a;
                        }
                    }
                    admins.Remove(adminToDelete);

                    //MessageBox.Show(adminToChange.ToString());

                    bool again = true;
                    foreach (Admin a in admins)
                    {
                        a.putAdmin(a, again);
                        again = false;
                    }

                    MessageBox.Show("Uspesno ste obrisali korisnika!");

                    //admins = Admin.getAdmins();
                    //lbAdmins.DataSource = clients;
                }
                else
                {
                    admins.Remove(adminToChange);
                    string toFile = "C:/Users/dzoni/source/repos/ProjekatTVP/ProjekatTVP/bin/Debug/Admins.bin";

                    bool again = true;
                    foreach (Admin a in admins)
                    {
                        a.putAdmin(a, again);
                        again = false;
                    }
                    //lbClients.DataSource = null;
                    File.WriteAllBytes(toFile, new byte[0]);

                    MessageBox.Show("Uspesno ste obrisali korisnika!");
                }
            }
        }
    }
}
