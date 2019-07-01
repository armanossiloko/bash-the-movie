using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class SubmittersController : ControllerBase
    {
        private ApplicationDbContext _context;

        public SubmittersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/Submitters/bugs/5
        [HttpGet("bugs/{id}")]
        public string BugSubmitter(int id)
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

        // GET api/Submitters/ideas/5
        [HttpGet("ideas/{id}")]
        public string FeedbackSubmitter(int id)
        {
            try
            {
                var entity = _context.Feedback.Include(x => x.User).FirstOrDefault(m => m.Id == id);
                return entity.User.Username;
            }
            catch
            {
                return "";
            }
        }

        // GET api/Submitters/support/5
        [HttpGet("support/{id}")]
        public string SupportSubmitter(int id)
        {
            try
            {
                var entity = _context.Tickets.Include(x => x.User).FirstOrDefault(m => m.Id == id);
                return entity.User.Username;
            }
            catch
            {
                return "";
            }
        }

        // GET api/Submitters/news/5
        [HttpGet("news/{id}")]
        public string NewsSubmitter(int id)
        {
            try
            {
                var entity = _context.News.Include(x => x.User).FirstOrDefault(m => m.Id == id);
                return entity.User.Username;
            }
            catch
            {
                return "";
            }
        }
    }
}