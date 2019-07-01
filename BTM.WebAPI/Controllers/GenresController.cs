using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace BTM.WebAPI.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private IDataService<Genre> _genreService;

        public GenresController(IDataService<Genre> genreService)
        {
            _genreService = genreService;
        }

        // GET: api/Genre
        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            return _genreService.Get();
        }

        // GET: api/Genre/5
        [HttpGet("{id}")]
        public Genre Get(int id)
        {
            return _genreService.Get(id);
        }

        // POST: api/Genre
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
    }
}
