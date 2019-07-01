using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private IDataService<Country> _countryService;

        public CountriesController(IDataService<Country> countryService)
        {
            _countryService = countryService;
        }

        // GET: api/Studio
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryService.Get();
        }

        // GET: api/Studio/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return _countryService.Get(id);
        }
    }
}