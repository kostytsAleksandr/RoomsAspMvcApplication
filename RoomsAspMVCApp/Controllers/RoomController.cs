using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using RoomMVC5Application.Models;
using Rooms.Domain.Models;

namespace RoomMVC5Application.Controllers
{
    public class RoomController : Controller
    {
        private readonly IMapper _mapper;
        public RoomController()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RoomModel, RoomViewModel>();
                cfg.CreateMap<PersonModel, PersonViewModel>();
                cfg.CreateMap<RoomModel, RoomPostModel>();
                cfg.CreateMap<PersonModel, PersonPostModel>();
            });

            _mapper = new Mapper(config);
        }
        // GET: AddRoom
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RoomPostModel model)
        {
            var createModel = _mapper.Map<RoomModel>(model);

            //_shopService.Create(createModel);

            return new EmptyResult();
        }
    }
}