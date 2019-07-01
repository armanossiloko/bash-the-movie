using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BTM.Database;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private IData<News> _newsData;

        public NewsController(IData<News> newsData)
        {
            _newsData = newsData;
        }

        // GET: api/News
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<News> GetNews()
        {
            return _newsData.Get();
        }

        // GET: api/News/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public News GetNews(int id)
        {
            return _newsData.Get(id);
        }

        // GET: api/News/image/5
        [HttpGet("image/{id}")]
        [AllowAnonymous]
        public IActionResult GetCover(int id)
        {
            News news = _newsData.Get(id);
            string filename = Path.GetFileName(news.Image);
            var image = System.IO.File.OpenRead($@"{Global.News}\{filename}");
            return File(image, "image/jpeg");
        }

        // PUT: api/News/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public News PutNews(int id, News news)
        {
            if (id != news.Id)
            {
                return null;
            }

            return _newsData.Update(news);
        }

        // POST: api/News
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public News PostNews(News news)
        {
            var returned = _newsData.Add(news);

            News added = new News
            {
                Id = returned.Id,
                Title = returned.Title,
                Content = returned.Content,
                Description = returned.Description,
                Logo = returned.Logo
            };

            return added;
        }

        //// DELETE: api/News/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<News>> DeleteNews(int id)
        //{
        //    var news = await _context.News.FindAsync(id);
        //    if (news == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.News.Remove(news);
        //    await _context.SaveChangesAsync();

        //    return news;
        //}
    }
}
