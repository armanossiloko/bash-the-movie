using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private IData<Media> _mediaData;
        //private UserManager<User> _userManager;
        //private SignInManager<User> _signInManager;

        public MediaController(IData<Media> mediaData)
            //UserManager<User> userManager,
            //SignInManager<User> signInManager)
        {
            _mediaData = mediaData;
            //_userManager = userManager;
            //_signInManager = signInManager;
        }

        // GET api/media
        [HttpGet]
        //[Authorize(Roles = "Member,Admin")]
        [AllowAnonymous]
        public IEnumerable<Media> Get()
        {
            return _mediaData.Get();
        }

        // GET api/media/5
        [HttpGet("{id}")]
        //[Authorize(Roles = "Member,Admin")]
        [AllowAnonymous]
        public Media Get(int id)
        {
            return _mediaData.Get(id);
        }

        // POST api/media
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Media Post(Media obj)
        {
            return _mediaData.Add(obj);
        }

        // PUT api/media/5
        [HttpPut("{id}")]
        public Media Put(int id, [FromBody] Media obj)
        {
           return _mediaData.Update(id, obj);
        }
    }
}