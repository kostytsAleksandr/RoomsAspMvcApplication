using Rooms.Data.Contracts;
using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void AddPersonToRoom(Room room, Person person)
        {
            using (var ctx = new RoomsContext())
            {
                person.RoomId = room.Id;
                person.Room = room;
                var tmpPerson=ctx.People
                    .FirstOrDefault(x => x.RoomId == room.Id);
                ctx.People.Remove(tmpPerson);
                ctx.People.Add(person);
                ctx.Rooms.FirstOrDefault(x => x.Id == room.Id).
                    People.Add(person);
                ctx.SaveChanges();
            }
        }

        public void Create(Person model)
        {
            using (var ctx = new RoomsContext())
            {
                ctx.People.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
