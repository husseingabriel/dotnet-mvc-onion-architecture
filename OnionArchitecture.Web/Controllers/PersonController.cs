using OnionArchitecture.Core.Entities;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Web.Models;
using OnionArchitecture.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnionArchitecture.Web.Controllers
{
    public class PersonController : BaseController
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            var lstPerson =_personService.GetPerson();
            var lstPersonViewModel = _mapper.Map<IEnumerable<PersonViewModel>>(lstPerson);

            return View(lstPersonViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonViewModel personViewModel)
        {
            if (ModelState.IsValid)
            {
                var person = _mapper.Map<Person>(personViewModel);
                _personService.Add(person);
                return View("Index");
            }

            return View();
        }
    }
}