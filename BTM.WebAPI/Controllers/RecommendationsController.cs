using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using BTM.Models.Comparers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationsController : ControllerBase
    {
        private ApplicationDbContext _context;
        private int positiveGrade = 6;
        private int maxResults = 3;

        public RecommendationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{UserID}")]
        public IEnumerable<Media> RecommentMovies(int UserID) //UserID
        {
            try
            {
                if (UserID == 0) // Don't even bother searching. Return random movies right away
                {
                    throw new Exception();
                }

                List<MediaUser> list = _context.MediaUsers.Where(x => x.UserID == UserID).Include(m => m.Media).AsNoTracking().ToList(); //enumerable
                var filteredList = list.Where(item => item.Grade >= positiveGrade).ToList(); //enumerable

                if (filteredList.Count() > 0)
                {
                    List<Genre> distinctGenres = new List<Genre>(); // Genres the user might be interested in
                    foreach (var item in filteredList)
                    {
                        var itemGenres = _context.MediaGenre.Where(m => m.MediaID == item.MediaID)
                            .Select(g => g.Genre)
                            .AsNoTracking()
                            .ToList();//enumerable

                        foreach (var genre in itemGenres)
                        {
                            /*if (!distinctGenres.Contains(genre))  //, new GenreComparer()
                            {
                                distinctGenres.Add(genre);
                            }*/

                            // Add only unique items to the list (no duplicates)
                            bool canBeAdded = true;
                            for (int i = 0; i < distinctGenres.Count; i++)
                            {
                                if (genre.Name == distinctGenres.ElementAt(i).Name)
                                {
                                    canBeAdded = false;
                                }
                            }

                            if (canBeAdded)
                            {
                                distinctGenres.Add(genre);
                            }
                        }
                    }

                    List<Media> listToReturn = new List<Media>();
                    foreach (var item in distinctGenres)
                    {
                        var moviesByGenre = _context.MediaGenre
                            .Where(g => g.GenreID == item.GenreID)
                            .Include(m => m.Media)
                            .Select(x => x.Media)
                            .AsNoTracking()
                            .ToList(); //enumerable
                        foreach (var movie in moviesByGenre)
                        {
                            /*if (!listToReturn.Contains(movie))
                            {
                                listToReturn.Add(movie);
                            }*/


                            // Add only unique items to the list (no duplicates)
                            bool canBeAdded = true;
                            for (int i = 0; i < listToReturn.Count; i++)
                            {
                                if (movie.Title == listToReturn.ElementAt(i).Title)
                                {
                                    canBeAdded = false;
                                }
                            }

                            // Check if the movie has been rated by the user already
                                // If so, don't add it
                            // End

                            if (canBeAdded)
                            {
                                listToReturn.Add(movie);
                            }
                        }
                    }

                    return listToReturn.OrderBy(media => Guid.NewGuid()).Take(maxResults);
                }
                throw new Exception();
            }
            catch
            {
                return _context.Media.AsNoTracking().OrderBy(media => Guid.NewGuid()).Take(maxResults).ToList(); //enumerable
            }

        }
    }
}