using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rooms.Data.Models;

namespace Rooms.Data.Contracts
{
    public interface IRoomRepository
    {
        void Create(Room model);
        IReadOnlyCollection<Room> GetAll();
    }
}
