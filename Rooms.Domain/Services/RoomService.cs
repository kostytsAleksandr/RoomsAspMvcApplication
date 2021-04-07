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
    public class RoomService:IRoomService
    {
        private readonly IMapper _mapper;
        public RoomService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<Person, PersonModel>();
            });

            _mapper = new Mapper(config);
        }

        public void Create(RoomModel model)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<RoomModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
