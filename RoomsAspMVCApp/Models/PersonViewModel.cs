using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomMVC5Application.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public int? RoomId { get; set; }
        public RoomViewModel Room { get; set; }
    }
}