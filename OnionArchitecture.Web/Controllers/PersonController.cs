using OnionArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnionArchitecture.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            var lstPerson =_personService.GetPerson();

            return View(lstPerson);
        }
    }
}