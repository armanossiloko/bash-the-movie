using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using BTM.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MediaRatingsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public MediaRatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public int GetRating(int id, string username)
        {
            var user = _context.Users.Where(u => u.Username == username).First();
            try
            {
                var rating = _context.MediaUsers.Where(x => x.MediaID == id && x.UserID == user.Id).First();
                return rating.Grade;
            }
            catch
            {
                return 0;
            }
        }

        [HttpPost]
        public void AddRating(MediaRatingInputModel model)
        {
            try
            {
                var obj = new MediaUser
                {
                    Grade = model.Rating,
                    MediaID = model.MediaID,
                    UserID = model.UserID
                };
                _context.MediaUsers.Add(obj);
                _context.SaveChanges();
                return;
            }
            catch
            {
                return;
            }
        }

        [HttpPut]
        public void Put(MediaRatingInputModel model)
        {
            try
            {
                var entity = _context.MediaUsers.Where(x => x.UserID == model.UserID && x.MediaID == model.MediaID).First();
                if (entity == null)
                {
                    return;
                }

                //var user = _context.Users.Where(u => u.Id == model.UserID).First();
                //var movie = _context.Media.Where(m => m.MediaID == model.MediaID).First();
                //var rating = new MediaUser
                //{
                //    MediaID = model.MediaID,
                //    UserID = model.UserID,
                //    Grade = model.Rating
                //};

                entity.Grade = model.Rating;
                _context.Attach(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return;
            }
            catch
            {
                return;
            }
            
        }

    }
}