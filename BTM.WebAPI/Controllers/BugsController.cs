using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using BTM.Models.Requests;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private IData<Bug> _bugData;
        private ApplicationDbContext _context;

        public BugsController(IData<Bug> bugData, ApplicationDbContext context)
        {
            _bugData = bugData;
            _context = context;
        }

        // GET api/bugs
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Bug> Get()
        {
            return _bugData.Get();
            //return _context.Bugs.AsEnumerable();
        }

        // GET api/bugs/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public Bug Get(int id)
        {
            var entity = _bugData.Get(id);
            var model = new Bug
            {
                Id = entity.Id,
                Description = entity.Description,
                Resolved = entity.Resolved,
                Title = entity.Title,
                Url = entity.Url,
                UserID = entity.UserID,
                DateAdded = entity.DateAdded
            };
            return model;
        }

        // POST api/bugs
        [Authorize(Roles = "Member,Admin")]
        [HttpPost]
        public Bug Post(Bug obj)
        {
            return _bugData.Add(obj);
        }

        // GET api/bugs/priority/5
        [HttpGet("priority/{id}")]
        [AllowAnonymous]
        public string Priority(int id)
        {
            var entity = _bugData.Get(id);
            return Enum.GetName(typeof(BTM.Models.Priority), (int)entity.Priority);
        }

        // GET api/bugs/submitter/5
        [HttpGet("submitter/{id}")]
        [AllowAnonymous]
        public string Submitter(int id)
        {
            try
            {
                var entity = _context.Bugs.Include(x => x.User).FirstOrDefault(m => m.Id == id);
                return entity.User.Username;
            }
            catch 
            {
                return "";
            }
            
        }

        // PUT api/bugs/5
        [Authorize(Roles = "Member,Admin")]
        [HttpPut("{id}")]
        public Bug Put(int id, BugEditModel obj)
        {
            var oldObj = _bugData.Get(id);
            if (oldObj == null)
            {
                return null;
            }

            oldObj.Title = obj.Title;
            oldObj.Url = obj.Url;
            oldObj.Resolved = obj.Resolved;
            oldObj.Description = obj.Description;

            return _bugData.Update(oldObj);
        }
    }
}