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
    public class Reservation
    {
        private static FileStream fsReservation;
        private static BinaryFormatter binF;

        private int userId;
        private int destinationId;
        private int totalPrice;
        private int numberOfReservedPlaces;
        private DateTime timeOfDeparture;
        private DateTime reservationTime;
        private Destination destinacija = new Destination();

        public Reservation(int userId, int destinationId, int totalPrice, int numberOfReservedPlaces, DateTime timeOfDeparture)
        {
            this.userId = userId;
            this.destinationId = destinationId;
            this.totalPrice = totalPrice;
            this.numberOfReservedPlaces = numberOfReservedPlaces;
            this.timeOfDeparture = timeOfDeparture;
            this.reservationTime = DateTime.Now;
            this.destinacija = destinacija.findDestination(destinationId);
        }

        public Reservation()
        {
           
        }

        public override string ToString()
        {
            return $"Rezervacija: Mesto:{destinacija.Location} Zemlja:{destinacija.Country} Putnika:{numberOfReservedPlaces} Datum:{destinacija.Date}";
        }

        public int UserId { get => userId; set => userId = value; }
        public int DestinationId { get => destinationId; set => destinationId = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int NumberOfReservedPlaces { get => numberOfReservedPlaces; set => numberOfReservedPlaces = value; }
        public DateTime ReservationTime { get => reservationTime; set => reservationTime = value; }
        public DateTime TimeOfDeparture { get => timeOfDeparture; set => timeOfDeparture = value; }

        public static List<Reservation> getReservations()
        {
            List<Reservation> Reservations = new List<Reservation>();
            try
            {
                if (File.Exists("Reservations.bin"))
                {
                    fsReservation = new FileStream("Reservations.bin", FileMode.Open, FileAccess.Read);
                    binF = new BinaryFormatter();
                    while (fsReservation.Position < fsReservation.Length)
                    {
                        Reservations.Add((Reservation)binF.Deserialize(fsReservation));
                    }
                    fsReservation.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return Reservations;
        }

        public void putReservation(Reservation r,bool again)
        {
            if (again)
            {
                fsReservation = new FileStream("Reservations.bin", FileMode.Create, FileAccess.Write);
                binF = new BinaryFormatter();
                binF.Serialize(fsReservation, r);
                fsReservation.Dispose();
                fsReservation.Close();
            }
            else
            {
                if (File.Exists("Reservations.bin"))
                {
                    fsReservation = new FileStream("Reservations.bin", FileMode.Append, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsReservation, r);
                    fsReservation.Close();
                }
                else
                {
                    fsReservation = new FileStream("Reservations.bin", FileMode.Create, FileAccess.Write);
                    binF = new BinaryFormatter();
                    binF.Serialize(fsReservation, r);
                    fsReservation.Dispose();
                    fsReservation.Close();
                }
            }            
        }

        //public static List<Reservation> getAllReservations()
        //{
        //    List<Reservation> Reservations = new List<Reservation>();
        //    try
        //    {
        //        if (File.Exists("AllReservations.bin"))
        //        {
        //            fsReservation = new FileStream("AllReservations.bin", FileMode.Open, FileAccess.Read);
        //            binF = new BinaryFormatter();
        //            while (fsReservation.Position < fsReservation.Length)
        //            {
        //                Reservations.Add((Reservation)binF.Deserialize(fsReservation));
        //            }
        //            fsReservation.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }

        //    return Reservations;
        //}

        //public void putToAllReservations(Reservation r)
        //{
        //        if (File.Exists("Reservations.bin"))
        //        {
        //            fsReservation = new FileStream("Reservations.bin", FileMode.Append, FileAccess.Write);
        //            binF = new BinaryFormatter();
        //            binF.Serialize(fsReservation, r);
        //            fsReservation.Close();
        //        }
        //        else
        //        {
        //            fsReservation = new FileStream("Reservations.bin", FileMode.Create, FileAccess.Write);
        //            binF = new BinaryFormatter();
        //            binF.Serialize(fsReservation, r);
        //            fsReservation.Dispose();
        //            fsReservation.Close();
        //        }
        //}
    }
}
