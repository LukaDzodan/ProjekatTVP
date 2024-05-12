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
    public partial class AddDestinationForm : Form
    {
        private Admin loginAdmin;

        List<string> SerbianCitys = new List<string>(){ "Beograd", "Novi Sad" };
        List<string> MontenegroCitys = new List<string>() { "Budva", "Herceg Novi" };
        List<string> SpanisCitys = new List<string>() { "Madrid", "Barcelona" };
        List<string> GermanyCitys = new List<string>() { "Minhen", "Berlin" };
        List<string> ItalianCitys = new List<string>() { "Rim", "Milano" };

        List<Destination> destinations = Destination.getDestinations();

        //Srbija Montenegro Spanija Nemacka Italija
        public AddDestinationForm(Admin admin)
        {
            InitializeComponent();
            this.loginAdmin = admin;
        }

        private void AddDestinationForm_Load(object sender, EventArgs e)
        {
            //Nista
        }

        private void cbCountrys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCountrys.Text == "Srbija")
            {
                cbLocations.DataSource = SerbianCitys;
                pbCountry.Image = Properties.Resources.srbijaFlag;
            }
            if (cbCountrys.Text == "Montenegro")
            {
                cbLocations.DataSource = MontenegroCitys;
                pbCountry.Image = Properties.Resources.montenegroFlag;
            }
            if (cbCountrys.Text == "Spanija")
            {
                cbLocations.DataSource = SpanisCitys;
                pbCountry.Image = Properties.Resources.SpanishFlag;
            }
            if (cbCountrys.Text == "Nemacka")
            {
                cbLocations.DataSource = GermanyCitys;
                pbCountry.Image = Properties.Resources.GermanyFlag;
            }
            if (cbCountrys.Text == "Italija")
            {
                cbLocations.DataSource = ItalianCitys;
                pbCountry.Image = Properties.Resources.ItalianFlag;
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            bool add = true;
            if (checkScopes())
            {
                
                RadioButton rb = checkRadioButtons(groupBox1);
                Destination destination = new Destination(cbLocations.SelectedItem.ToString(), cbCountrys.SelectedItem.ToString(), int.Parse(txtPrice.Text), rb.Text,int.Parse(txtDaysNumbers.Text),int.Parse(txtTotalPlaces.Text),dateTimePicker1.Value);

                foreach (Destination d in destinations)
                {
                    if (d.Country == destination.Country && d.Location == destination.Location && d.Date.Day == destination.Date.Day && d.Date.Month == destination.Date.Month)
                    {
                        add = false;
                        MessageBox.Show("Takva destinacija vec postoji!");
                        break;
                    }
                }

                if (add)
                {
                    destinations.Add(destination);
                    bool again = true;
                    foreach (Destination d in destinations)
                    {
                        d.putDestination(d, again);
                        d.putToAllDestination(d);
                        again = false;
                    }
                    MessageBox.Show("Uspesno ste dodali novu destinaciju!");
                }
            }
        }

        private bool checkScopes()
        {
            if(cbCountrys.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali zemlju!");
                return false;
            }
            if (cbLocations.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali validno mesto!");
                return false;
            }
            if (txtPrice.Text == "" || int.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show("Niste upisali validnu cenu!");
                return false;
            }
            if(rbNothing.Checked == false && rbDiscount5.Checked == false && rbDiscount10.Checked == false && rbDiscount15.Checked == false && rbDiscount20.Checked == false && rbDiscount30.Checked == false)
            {
                MessageBox.Show("Niste izabrali validan popust!");
                return false;
            }
            if(txtDaysNumbers.Text == "" || int.Parse(txtDaysNumbers.Text) <= 0)
            {
                MessageBox.Show("Niste upisali validan broj dana!");
                return false;
            }
            if (txtTotalPlaces.Text == "" || int.Parse(txtTotalPlaces.Text) <= 0 )
            {
                MessageBox.Show("Niste upisali validan broj mesta!");
                return false;
            }
            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Los datum ste izabrali!");
                return false;
            }
            return true;
        }

        public RadioButton checkRadioButtons(Control radioButtons)
        {
            foreach(Control control in radioButtons.Controls)
            {
                if(control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton;
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(loginAdmin);
            this.Hide();
            adminForm.Show();

        }

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLocations.SelectedItem == "Beograd")
            {
                pbLocations.Image = Properties.Resources.beograd;
            }
            if (cbLocations.SelectedItem == "Novi Sad")
            {
                pbLocations.Image = Properties.Resources.noviSad;
            }
            if (cbLocations.SelectedItem == "Budva")
            {
                pbLocations.Image = Properties.Resources.Budva;
            }
            if (cbLocations.SelectedItem == "Herceg Novi")
            {
                pbLocations.Image = Properties.Resources.hercegNovi;
            }
            if (cbLocations.SelectedItem == "Madrid")
            {
                pbLocations.Image = Properties.Resources.Madrid;
            }
            if (cbLocations.SelectedItem == "Barcelona")
            {
                pbLocations.Image = Properties.Resources.Barcelona;
            }
            if (cbLocations.SelectedItem == "Minhen")
            {
                pbLocations.Image = Properties.Resources.Minhen;
            }
            if (cbLocations.SelectedItem == "Berlin")
            {
                pbLocations.Image = Properties.Resources.Berlin;
            }
            if (cbLocations.SelectedItem == "Rim")
            {
                pbLocations.Image = Properties.Resources.Rim;
            }
            if (cbLocations.SelectedItem == "Milano")
            {
                pbLocations.Image = Properties.Resources.MIlano;
            }
        }
    }
}
