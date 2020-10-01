using AutoMapper;
using OnionArchitecture.Core.Entities;
using OnionArchitecture.Web.ViewModels;
using System.Web.Mvc;

namespace OnionArchitecture.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        public BaseController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Person, PersonViewModel>();
                x.CreateMap<PersonViewModel, Person>();
            });
            _mapper = config.CreateMapper();
        }
    }
}