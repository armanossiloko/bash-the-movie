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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MediaSearchController : ControllerBase
    {
        private ApplicationDbContext _context;

        public MediaSearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/mediasearch
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Media> Get([FromQuery] MediaSearchRequest request)
        {
			if ((request.Title == "" || request.Title == null) && request.GenreID == 0 && request.Year == 0)
            {
                return _context.Media.AsNoTracking().AsEnumerable();
            }
            else
            {
                var list = _context.MediaGenre
                    .Include(m => m.Media)
                    .AsNoTracking()
                    .AsEnumerable();

                if (request.Title != "" && request.Title != null)
                {
                    list = list.Where(x => x.Media.Title.Contains(request.Title)).AsEnumerable();
                }

                if (request.GenreID != 0)
                {
                    list = list.Where(x => x.GenreID == request.GenreID)
                        .AsEnumerable();
                }

                if (request.Year != 0)
                {
                    list = list.Where(x => x.Media.ReleaseDate.Year == request.Year)
                        .AsEnumerable();

                    var lst = list.ToList();
                }

                return list.Select(med => med.Media).Distinct();
            }
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public MediaDetailModel GetMedia(int id)
        {
            var mediaGenres = _context.MediaGenre
                .Include(m => m.Genre)
                .Where(q => q.MediaID == id)
                .AsNoTracking()
                .AsEnumerable()
                .Select(g => g.Genre);

            var mediaCountries = _context.MediaCountries
                .Include(m => m.Country)
                .Where(q => q.MediaID == id)
                .AsNoTracking()
                .AsEnumerable()
                .Select(l => l.Country);

            var mediaLanguages = _context.MediaLanguage
                .Include(m => m.Language)
                .Where(q => q.MediaID == id)
                .AsNoTracking()
                .AsEnumerable()
                .Select(l => l.Language);

            var mediaKeywords = _context.MediaPlotKeywords
                .Include(m => m.Keyword)
                .Where(q => q.MediaID == id)
                .AsNoTracking()
                .AsEnumerable()
                .Select(k => k.Keyword);

            var poster = _context.Images.Where(m => m.MediaID == id).FirstOrDefault().Location;

            var media = _context.Media
                .Include(r => r.Rating)
                .Include(s => s.Studio)
                .FirstOrDefault(movie => movie.MediaID == id);

            MediaDetailModel model = new MediaDetailModel
            {
                Budget = media.Budget.ToString(),
                BoxOffice = media.WorldwideGross.ToString(),
                Genres = string.Join(", ", mediaGenres),
                DateReleased = media.ReleaseDate,
                Director = media.Director,
                Id = media.MediaID,
                Synopsis = media.Synopsis,
                Title = media.Title,
                Keywords = string.Join(", ", mediaKeywords),
                Languages = string.Join(", ", mediaLanguages),
                Country = string.Join(", ", mediaCountries)
            };

            return model;
        }
    }
}