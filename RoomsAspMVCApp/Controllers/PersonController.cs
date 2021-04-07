using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomMVC5Application.Controllers
{
    public class PersonController : Controller
    {
        // GET: AddPerson
        public ActionResult Index()
        {
            return View();
        }
    }
}