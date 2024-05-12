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
    public partial class CreateAccForm : Form
    {
        List<Client> Clients;
        LoginForm loginForm = new LoginForm();
        private Admin loginAdmin;
        public CreateAccForm()
        {
            InitializeComponent();
        }

        public CreateAccForm(Admin loginAdmin)
        {
            InitializeComponent();
            this.loginAdmin = loginAdmin;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Nista
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(loginAdmin == null)
            {
                this.Close();
                loginForm.Show();
            }
            else
            {
                AdminForm adminForm = new AdminForm(loginAdmin);
                this.Close();
                adminForm.Show();
            }

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            if(txtCreateUserName.Text != "" && txtCreatePassword.Text != "" && txtName.Text!= "" && txtSurname.Text != "") {
            
                  foreach(Client k in Clients)
                {
                    if(k.UserName == txtCreateUserName.Text)
                    {
                        MessageBox.Show("Takvo korisnicko ime vec postoji!");
                        postoji = true;
                    }
                }

                if (!postoji)
                {
                    Client k = new Client(txtCreateUserName.Text, txtCreatePassword.Text,txtName.Text,txtSurname.Text);
                    k.putClient(k,false);
                    MessageBox.Show("Uspesno ste napravili client nalog!");
                }

            }
        }

        private void CreateAccForm_Load(object sender, EventArgs e)
        {
            Clients = Client.getClients();
        }
    }
}
