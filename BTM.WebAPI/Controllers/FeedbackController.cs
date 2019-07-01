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
    public class FeedbackController : ControllerBase
    {
        private IData<Feedback> _feedbackData;

        public FeedbackController(IData<Feedback> feedbackData)
        {
            _feedbackData = feedbackData;
        }

        // GET api/feedback
        [HttpGet]
        public IEnumerable<Feedback> Get()
        {
            return _feedbackData.Get();
        }

        // GET api/feedback/5
        [HttpGet("{id}")]
        //[Authorize(Roles = "Member,Admin")]
        [AllowAnonymous]
        public Feedback Get(int id)
        {
            var entity = _feedbackData.Get(id);
            var model = new Feedback
            {
                Id = entity.Id,
                Name = entity.Name,
                Content = entity.Content,
                Addressed = entity.Addressed,
                DateAdded = entity.DateAdded,
                UserID = entity.UserID,
            };
            return model;
        }

        // POST api/feedback
        [Authorize(Roles = "Member,Admin")]
        [HttpPost]
        public Feedback Post(Feedback obj)
        {
            return _feedbackData.Add(obj);
        }

        // PUT api/feedback/5
        [HttpPut("{id}")]
        public Feedback Put(int id, FeedbackEditModel obj)
        {
            var oldObj = _feedbackData.Get(id);
            if (oldObj == null)
            {
                return null;
            }

            oldObj.Name = obj.Name;
            oldObj.Addressed = obj.Addressed;
            oldObj.Content = obj.Content;

            return _feedbackData.Update(oldObj);
        }
    }
}