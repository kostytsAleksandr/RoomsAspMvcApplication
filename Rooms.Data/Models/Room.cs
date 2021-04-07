using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int CountPlaces { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
