using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int CountPlaces { get; set; }

        public ICollection<PersonModel> People { get; set; }
    }
}
