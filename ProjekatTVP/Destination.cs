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

    public class Destination
    {
        private static FileStream fsDestination;
        private static BinaryFormatter binF;

        private int ID;
        private string location;
        private string country;
        private int price;
        private string discount;
        private int daysNumber;
        private int totalPlaces;
        private DateTime date;

        public Destination(string location, string country, int price, string discount, int daysNumber, int totalPlaces, DateTime date)
        {
            ID = addID();
            this.location = location;
            this.country = country;
            this.price = price;
            this.discount = discount;
            this.daysNumber = daysNumber;
            this.totalPlaces = totalPlaces;
            this.date = date;
        }

        public Destination()
        {
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Location { get => location; set => location = value; }
        public string Country { get => country; set => country = value; }
        public int Price { get => price; set => price = value; }
        public string Discount { get => discount; set => discount = value; }
        public int DaysNumber { get => daysNumber; set => daysNumber = value; }
        public int TotalPlaces { get => totalPlaces; set => totalPlaces = value; }
        public DateTime Date { get => date; set => date = value; }

        public static List<Destination> getDestinations()
        {
            List<Destination> Destinations = new List<Destination>();
            try
            {
                if (File.Exists("Destinations.bin"))
                {
                    fsDestination = new FileStream("Destinations.bin", FileMode.Open, FileAccess.Read);
                    binF = new BinaryFormatter();
                    //Destinations = binF.Deserialize(fsDestination) as List<Destination>;
                    while (fsDestination.Position < fsDestination.Length)
                    {
                        Destinations.Add((Destination)binF.Deserialize(fsDestination));
                    }
                    fsDestination.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Destinations;
        }

        public void putDestination(Destination d,bool again)
        {
            if (again)
            {
                fsDestination = new FileStream("Destinations.bin", FileMode.Create, FileAccess.Write);
                binF = new BinaryFormatter();
                binF.Serialize(fsDestination, d);
                fsDestination.Dispose();
                fsDestination.Close();
            }
            else
            {
                if (File.Exists("Destinations.bin"))
                {
                    fsDestination = new FileStream("Destinations.bin", FileMode.Append, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsDestination, d);
                    fsDestination.Dispose();
                    fsDestination.Close();
                }
                else
                {
                    fsDestination = new FileStream("Destinations.bin", FileMode.Create, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsDestination, d);
                    fsDestination.Dispose();
                    fsDestination.Close();
                }
            }
        }

        public static List<Destination> getAllDestinations()
        {
            List<Destination> Destinations = new List<Destination>();
            try
            {
                if (File.Exists("AllDestinations.bin"))
                {
                    fsDestination = new FileStream("AllDestinations.bin", FileMode.Open, FileAccess.Read);
                    binF = new BinaryFormatter();
                    //Destinations = binF.Deserialize(fsDestination) as List<Destination>;
                    while (fsDestination.Position < fsDestination.Length)
                    {
                        Destinations.Add((Destination)binF.Deserialize(fsDestination));
                    }
                    fsDestination.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Destinations;
        }

        public void putToAllDestination(Destination d)
        {
                if (File.Exists("AllDestinations.bin"))
                {
                    fsDestination = new FileStream("AllDestinations.bin", FileMode.Append, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsDestination, d);
                    fsDestination.Dispose();
                    fsDestination.Close();
                }
                else
                {
                    fsDestination = new FileStream("AllDestinations.bin", FileMode.Create, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsDestination, d);
                    fsDestination.Dispose();
                    fsDestination.Close();
                }
        }

        public Destination findDestination(int ID)
        {
            List<Destination> destinations = getDestinations();
            Destination dest = new Destination();
            foreach (Destination d in destinations)
            {
                if (d.ID1 == ID)
                {
                    dest = d;
                }
            }
            return dest;
        }

        public int addID()
        {
            int id;
            List<Destination> Destinations = getDestinations();
            if (Destinations.Count > 0)
            {
                id = (1 + Destinations.Last().ID1);
                return id;
            }
            else
            {
                id = 0;
                return id;
            }
        }

        public override string ToString()
        {
            return $"Mesto:{location} Lokacija: {country} Cena: {price} Popust:{discount} Broj dana:{daysNumber} Broj mesta:{totalPlaces} Datum polaska:{date}";

        }
    }
}
