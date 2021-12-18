using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Table
    {
        public Table()
        {
            Guests = new List<Guest>
            {
                new Guest(){Name = "John"},
                new Guest(){Name = "Charlie"},
                new Guest(){Name = "Jill"},
                new Guest(){Name = "Jane"},
                new Guest(){Name = "Martin"},
                new Guest(){Name = "Ann"},
                new Guest(){Name = "Eve"}
            };
        }

        private List<Guest> Guests { get; set; }

        public Guest this[int index]
        {
            get => Guests[index];

            set => Guests[index] = value;
        }

        public Guest this[int index, string name]
        {
            get => Guests.Where(guest => guest.Name == name).First();
            set => Guests[index] = value;
        }
    }
}
