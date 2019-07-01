using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private ICRData<People> _peopleData;

        public PeopleController(ICRData<People> peopleData)
        {
            _peopleData = peopleData;
        }

        [HttpGet]
        public IEnumerable<People> Get()
        {
            return _peopleData.Get();
        }

        [HttpGet("{id}")]
        public People Get(int id)
        {
            return _peopleData.Get(p => p.PeopleID == id);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public People Add(People people)
        {
            return _peopleData.Add(people);
        }
    }
}
