using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomMVC5Application.Models
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int CountPlaces { get; set; }

        public ICollection<PersonViewModel> People { get; set; }
    }
}