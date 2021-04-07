using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Contracts
{
    public interface IPersonRepository
    {
        void Create(Person model);
        void AddPersonToRoom(Room room, Person person);
    }
}
