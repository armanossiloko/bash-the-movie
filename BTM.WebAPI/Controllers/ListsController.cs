using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
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
    public class ListsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<List> Get()
        {
            return _context.Lists.AsNoTracking().AsEnumerable();
        }

        [HttpGet("users/{id}")]
        [AllowAnonymous]
        public IEnumerable<List> Get(int id)
        {
            return _context.Lists.AsNoTracking().Where(item => item.UserID == id).AsEnumerable();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public List GetList(int id)
        {
            return _context.Lists.AsNoTracking().FirstOrDefault(item => item.ListID == id);
        }

        [HttpGet("media/{id}")]
        [AllowAnonymous]
        public IEnumerable<Media> GetMedia(int id)
        {
            return _context.MediaLists
                .Include(med => med.Media)
                .AsNoTracking()
                .Where(item => item.ListID == id)
                .Select(r => r.Media)
                .AsEnumerable();
        }

        [HttpPost("AddMovie")]
        public void PostMovie(MediaList model)
        {
            if (model == null)
            {
                return;
            }
            bool exists = _context.MediaLists.AsNoTracking().Any(x => x.ListID == model.ListID && x.MediaID == model.MediaID);
            if (exists)
            {
                return;
            }

            _context.MediaLists.Add(model);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Post(List model)
        {
            if (model == null)
            {
                return;
            }

            _context.Lists.Add(model);
            _context.SaveChanges();
        }
    }
}