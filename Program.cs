using System.Net.Sockets;

namespace OOP3
{
    #region part2

   /* class Ticket
    {
        private static int ticketCounter = 0;

        public string MovieName { get; set; }
        public decimal Price { get; protected set; }
        public int TicketId { get; }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;

            if (price <= 0)
                throw new ArgumentException("Price must be greater than 0.");

            Price = price;

            ticketCounter++;
            TicketId = ticketCounter;
        }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public static int GetTotalTickets()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return "Ticket ID: " + TicketId +
                   " | Movie: " + MovieName +
                   " | Price: " + Price +
                   " EGP | After Tax: " + PriceAfterTax +
                   " EGP";
        }
    }

    class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(
            string movieName,
            decimal price,
            string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | Seat: " + SeatNumber;
        }
    }

    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public VIPTicket(
            string movieName,
            decimal price,
            bool loungeAccess)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | Lounge Access: " + LoungeAccess +
                   " | Service Fee: " + ServiceFee + " EGP";
        }
    }

    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(
            string movieName,
            decimal price,
            bool is3D)
            : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | 3D: " + Is3D;
        }
    }

    sealed class Projector
    {
        public void Start()
        {
            Console.WriteLine("Projector is ON.");
        }

        public void Stop()
        {
            Console.WriteLine("Projector is OFF.");
        }
    }

    class Cinema
    {
        public string CinemaName { get; set; }

        private Projector projector;
        private Ticket[] tickets = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            projector = new Projector();
        }

        public void OpenCinema()
        {
            Console.WriteLine(CinemaName + " is opening.");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
            Console.WriteLine(CinemaName + " is closing.");
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n===== All Tickets =====");

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    Console.WriteLine(tickets[i].ToString());
                }
            }
        }
    }
   */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part2
            /*
            Cinema cinema = new Cinema("Assignment Cinema");

            // Open cinema
            cinema.OpenCinema();

            // Create one ticket of each type
            StandardTicket standard = new StandardTicket(
                "Inception", 100m, "A5");

            VIPTicket vip = new VIPTicket(
                "Avengers", 200m, true);

            IMAXTicket imax = new IMAXTicket(
                "Dune", 150m, true);

            // Add tickets to cinema
            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            // Print all tickets
            cinema.PrintAllTickets();

            Console.WriteLine(
                "\nTotal Tickets Created: " +
                Ticket.GetTotalTickets());

            // Close cinema
            Console.WriteLine();
            cinema.CloseCinema();
            */
            #endregion
        }
    }
}
