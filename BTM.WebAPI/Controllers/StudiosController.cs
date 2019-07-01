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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudiosController : ControllerBase
    {
        private IDataService<Studio> _studioService;

        public StudiosController(IDataService<Studio> studioService)
        {
            _studioService = studioService;
        }

        // GET: api/Studio
        [HttpGet]
        public IEnumerable<Studio> Get()
        {
            return _studioService.Get();
        }

        // GET: api/Studio/5
        [HttpGet("{id}")]
        public Studio Get(int id)
        {
            return _studioService.Get(id);
        }
    }
}
