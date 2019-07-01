using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using BTM.Models.Requests;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        //[HttpGet]
        //public List<User> Get()
        //{
        //    return _service.Get().ToList();
        //}

        [HttpGet]
        //[AllowAnonymous]
        //[Authorize(Roles = "Member,Admin")]
        public List<User> Get([FromQuery] UserSearchModel request)
        {
            return _service.Get(request);
        }

        [HttpGet("userid/{username}")]
        [AllowAnonymous]
        public User GetId(string username)
        {
            try
            {
                var model = _service.Get(x => x.Username == username);
                var obj = new User
                {
                    Id = model.Id,
                    Username = model.Username,
                    Avatar = model.Avatar,
                    DateOfBirth = model.DateOfBirth,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    JoinDate = model.JoinDate
                };
                return obj;
            }
            catch (Exception)
            {
                return null;
            } 
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public User Get(int id)
        {
            return _service.Get(id);
        }

        // GET api/Users/avatars/5
        [HttpGet("avatars/{id}")]
        [AllowAnonymous]
        public IActionResult GetAvatar(int id) // UserID
        {
            try
            {
                var model = _service.Get(x => x.Id == id);

                if (model == null)
                {
                    throw new Exception();
                }

                string filename = Path.GetFileName(model.Avatar);
                if (filename == null || filename == "")
                {
                    filename = "Default.png";
                }
                var image = System.IO.File.OpenRead($@"{Global.Avatars}\{filename}");
                return File(image, "image/jpeg");
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public User Post(UserRegistrationModel request)
        {
            var obj = _service.Register(request);
            User user = new User
            {
                Id = obj.Id,
                Username = obj.Username,
                Email = obj.Email,
                LastName = obj.LastName,
                MiddleName = obj.MiddleName,
                FirstName = obj.FirstName
            };
            return user;
        }

        //[Authorize(Roles = "Member")]
        //[HttpPut("{id}")]
        //public User Update(int id, [FromBody]User request)
        //{
        //    return _service.Update(id, request);
        //}
    }
}