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
    public partial class LoginForm : Form
    {
        List<Client> Clients;
        List<Admin> Admins;
        ClientForm clientForm;
        AdminForm adminForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" || txtPassword.Text != "")
            {
                if (rbAdmin.Checked)
                {
                    bool postoji= false;
                    foreach(Admin a in Admins)
                    {
                        if(a.UserName == txtUserName.Text && a.Password == txtPassword.Text)
                        {
                            postoji = true;
                            adminForm = new AdminForm(a);
                            adminForm.Show();
                            this.Hide();
                            MessageBox.Show($"Dobrodosli {a.UserName}");
                        }
                    }

                    if (postoji == false)
                    {
                        MessageBox.Show("Ne postoji admin sa takvim imenom");
                    }           
                }
                else if (rbClient.Checked)
                {
                    bool postoji = false;
                    foreach (Client a in Clients)
                    {
                        if (a.UserName == txtUserName.Text && a.Password == txtPassword.Text)
                        {
                            postoji = true;
                            clientForm = new ClientForm(a);
                            clientForm.Show();
                            this.Hide();
                            MessageBox.Show($"Dobrodosli {a.UserName}");
                        }
                    }

                    if (postoji == false)
                    {
                        MessageBox.Show("Ne postoji client sa takvim Imenom");
                    }                
                }
                else
                {
                    MessageBox.Show("Morate izabrati vrstu korisnika");
                }
            }
            else
            {
                MessageBox.Show("Jedno od polja nije popunjeno");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CreateAccForm createAccForm = new CreateAccForm();
            createAccForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Clients = Client.getClients();
            Admins = Admin.getAdmins();
            txtUserName.Text = "Luka";
            txtPassword.Text = "luka123";
            rbAdmin.Checked = true;
            //Admin a = new Admin("Luka","luka123","Luka","Dzodan");
            //a.putAdmin(a, true);
        }
    }
}
