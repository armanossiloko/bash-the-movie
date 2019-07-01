using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaContentController : ControllerBase
    {
        private ApplicationDbContext _context;

        public MediaContentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST api/MediaContent/Genres
        [HttpPost("Genres")]
        [Authorize(Roles = "Admin")]
        public IActionResult PostGenre(MediaGenre obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            _context.MediaGenre.Add(obj);
            _context.SaveChanges();

            var model = new MediaGenre
            {
                GenreID = obj.GenreID,
                MediaID = obj.MediaID
            };
            return Ok(model);
        }

        // POST api/MediaContent/Countries
        [HttpPost("Countries")]
        [Authorize(Roles = "Admin")]
        public IActionResult PostCountry(MediaCountry obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            _context.MediaCountries.Add(obj);
            _context.SaveChanges();

            var model = new MediaCountry
            {
                CountryID = obj.CountryID,
                MediaID = obj.MediaID
            };
            return Ok(model);
        }

        // POST api/MediaContent/Languages
        [HttpPost("Languages")]
        [Authorize(Roles = "Admin")]
        public IActionResult PostLanguage(MediaLanguage obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            _context.MediaLanguage.Add(obj);
            _context.SaveChanges();

            var model = new MediaLanguage
            {
                LanguageID = obj.LanguageID,
                MediaID = obj.MediaID
            };
            return Ok(model);
        }
    }
}