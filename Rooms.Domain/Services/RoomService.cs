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
    public class RoomService : IRoomService
    {
        private readonly IMapper _mapper;
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<Person, PersonModel>();
            });

            _mapper = new Mapper(config);
            _roomRepository = roomRepository;
        }

        public void Create(RoomModel model)
        {
            var room = _mapper.Map<Room>(model);
            _roomRepository.Create(room);
        }

        public IReadOnlyCollection<RoomModel> GetAll()
        {
            var rooms = _roomRepository.GetAll();
            var roomsModel = _mapper.Map<IReadOnlyCollection<RoomModel>>(rooms);
            return roomsModel;
        }
    }
}
