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
    public class Client
    {
        private static FileStream fsClient;
        private static BinaryFormatter binF;

        private int ID;
        private string pristup;
        private string name;
        private string surname;
        private string userName;
        private string password;
        public Client(string userName, string password, string name, string surname)
        {
            ID = addID();
            this.pristup = "Client";
            this.userName = userName;
            this.password = password;
            this.name = name;
            this.surname = surname;
        }

        public Client()
        {
        }

        public string Pristup { get => pristup; set => pristup = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public static List<Client> getClients()
        {
            List<Client> Clients = new List<Client>();
            try
            {
                if (File.Exists("Clients.bin"))
                {
                    fsClient = new FileStream("Clients.bin", FileMode.Open, FileAccess.Read);
                    binF = new BinaryFormatter();
                    //Clients = (List<Client>)binF.Deserialize(fsClient);
                    while (fsClient.Position < fsClient.Length)
                    {
                        Clients.Add((Client)binF.Deserialize(fsClient));
                    }
                    fsClient.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return Clients;
        }

        public void putClient(Client c, bool again)
        {
            if (again)
            {
                fsClient = new FileStream("Clients.bin", FileMode.Create, FileAccess.Write);
                binF = new BinaryFormatter();
                binF.Serialize(fsClient, c);
                fsClient.Dispose();
                fsClient.Close();
            }
            else
            {
                if (File.Exists("Clients.bin"))
                {
                    fsClient = new FileStream("Clients.bin", FileMode.Append, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsClient, c);
                    fsClient.Close();
                }
                else
                {
                    fsClient = new FileStream("Clients.bin", FileMode.Create, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsClient, c);
                    fsClient.Dispose();
                    fsClient.Close();
                }
            }
            

        }

        //public void putClients(List<Client> c)
        //{
        //    if (File.Exists("Clients.bin"))
        //    {
        //        fsClient = new FileStream("Clients.bin", FileMode.Append, FileAccess.Write);
        //        binF = new BinaryFormatter();
        //        binF.Serialize(fsClient, c);
        //        fsClient.Close();
        //    }
        //    else
        //    {
        //        fsClient = new FileStream("Clients.bin", FileMode.Create, FileAccess.Write);
        //        binF = new BinaryFormatter();
        //        binF.Serialize(fsClient, c);
        //        fsClient.Dispose();
        //        fsClient.Close();
        //    }

        //}
        public override string ToString()
        {
            return "Ime: " + userName + " Pristup: " + pristup + "Ime: " + name + "Surname: " + surname;
        }

        public int addID()
        {
            int id;
            List<Client> Clients = getClients();
            if(Clients.Count > 0)
            {
                id = (1 + Clients.Last().ID1);
                return id;
            }
            else
            {
                id = 0;
                return id;
            }
        }

        public bool checkIsExist(string ime,List<Client> lista)
        {
            foreach (Client k in lista)
            {
                if(k.UserName == ime)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
