using System;
using System.Collections.Generic;
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
    public class SupportController : ControllerBase
    {
        private IData<Ticket> _ticketData;

        public SupportController(IData<Ticket> ticketData)
        {
            _ticketData = ticketData;
        }

        // GET api/support
        [HttpGet]
        [Authorize(Roles = "Member,Admin")]
        //[AllowAnonymous]
        public IEnumerable<Ticket> Get()
        {
            return _ticketData.Get();
        }

        // GET api/support/users/5
        [HttpGet("users/{id}")]
        [Authorize(Roles = "Member,Admin")]
        public IEnumerable<Ticket> GetByUser(int id)
        {
            return _ticketData.GetByCondition(x => x.UserID == id).AsEnumerable();
        }

        // GET api/support/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Member,Admin")]
        public Ticket Get(int id)
        {
            var entity = _ticketData.Get(id);
            var model = new Ticket
            {
                Id = entity.Id,
                Content = entity.Content,
                Resolved = entity.Resolved,
                Title = entity.Title,
                UserID = entity.UserID,
                DateAdded = entity.DateAdded
            };
            return model;
        }

        // POST api/support
        [Authorize(Roles = "Member,Admin")]
        [HttpPost]
        public Ticket Post(Ticket obj)
        {
            return _ticketData.Add(obj);
        }

        // PUT api/values/5
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public void Put(int id, TicketEditModel obj)
        {
            var oldObj = _ticketData.Get(id);
            if (oldObj == null)
            {
                return;
            }

            oldObj.Title = obj.Title;
            oldObj.Resolved = obj.Resolved;
            oldObj.Content = obj.Content;

            var newObj = _ticketData.Update(oldObj);
        }
    }
}