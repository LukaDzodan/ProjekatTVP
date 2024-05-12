using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{   
    [Serializable]
    public class Admin
    {
        private static FileStream fsAdmin;
        private static BinaryFormatter binF;

        private int ID;
        string pristup;
        string userName;
        string name;
        string surname;
        private string password;
        public Admin(string userName,string password, string name, string surname)
        {
            this.ID1 = addID();
            this.Pristup = "Admin";
            this.Name = name;
            this.Surname = surname;
            this.UserName = userName;
            this.Password = password;
        }

        public Admin()
        {
        }

        public string Pristup { get => pristup; set => pristup = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public static List<Admin> getAdmins()
        {
            List<Admin> Admins = new List<Admin>();
            try
            {
                if (File.Exists("Admins.bin"))
                {
                    fsAdmin = new FileStream("Admins.bin", FileMode.Open, FileAccess.Read);
                    binF = new BinaryFormatter();
                    while (fsAdmin.Position < fsAdmin.Length)
                    {
                        Admins.Add((Admin)binF.Deserialize(fsAdmin));
                    }
                    fsAdmin.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return Admins;
        }

        
        public void putAdmin(Admin a,bool again)
        {
            if (again)
            {
                fsAdmin = new FileStream("Admins.bin", FileMode.Create, FileAccess.Write);
                binF = new BinaryFormatter();
                binF.Serialize(fsAdmin, a);
                fsAdmin.Dispose();
                fsAdmin.Close();
            }
            else
            {
                if (File.Exists("Admins.bin"))
                {
                    fsAdmin = new FileStream("Admins.bin", FileMode.Append, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsAdmin, a);
                    fsAdmin.Close();
                }
                else
                {
                    fsAdmin = new FileStream("Admins.bin", FileMode.Create, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsAdmin, a);
                    fsAdmin.Dispose();
                    fsAdmin.Close();
                }
            }
        }

        public override string ToString()
        {
            return "Ime: " + UserName + "Pristup: " + Pristup + "Ime: " + Name + "Surname: " + Surname;
        }

        public int addID()
        {
            int id;
            List<Admin> Admins = getAdmins();
            if (Admins.Count > 0)
            {
                id = (1 + Admins.Last().ID1);
                return id;
            }
            else
            {
                id = 0;
                return id;
            }
        }

        public bool checkIsExist(string ime, List<Admin> lista)
        {
            foreach (Admin a in lista)
            {
                if (a.UserName == ime)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
