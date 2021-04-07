using Rooms.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Contracts
{
    public interface IPersonService
    {
        void Create(PersonModel model);
        void AddPersonToRoom(RoomModel room, PersonModel person);
    }
}
