using AutoMapper;
using Rooms.Data.Models;
using Rooms.Domain.Contracts;
using Rooms.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        public PersonService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<Person, PersonModel>();
            });

            _mapper = new Mapper(config);
        }

        public void AddPersonToRoom(RoomModel room, PersonModel person)
        {
            throw new NotImplementedException();
        }

        public void Create(PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
