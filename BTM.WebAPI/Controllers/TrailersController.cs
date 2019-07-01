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
    public class TrailersController : ControllerBase
    {
        private IData<Trailer> _trailerData;

        public TrailersController(IData<Trailer> trailerData)
        {
            _trailerData = trailerData;
        }

        // GET api/trailers/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public Trailer Get(int id) // mediaID
        {
            return _trailerData.Get(x => x.MediaID == id);
        }

        // POST api/trailers
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public Trailer Post(Trailer obj)
        {
            return _trailerData.Add(obj);
        }

        // POST api/trailers/5
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public Trailer Put(int id,Trailer obj)
        {
            return _trailerData.Update(obj);
        }
    }
}