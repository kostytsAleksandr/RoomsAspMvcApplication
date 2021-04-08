using AutoMapper;
using Rooms.Data.Contracts;
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
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<Person, PersonModel>();
            });

            _mapper = new Mapper(config);
            _personRepository = personRepository;
        }

        public void AddPersonToRoom(RoomModel roomModel, PersonModel personModel)
        {
            var room = _mapper.Map<Room>(roomModel);
            var person = _mapper.Map<Person>(personModel);
            _personRepository.AddPersonToRoom(room, person);
        }

        public void Create(PersonModel personModel)
        {
            var person = _mapper.Map<Person>(personModel);
            _personRepository.Create(person);
        }
    }
}
