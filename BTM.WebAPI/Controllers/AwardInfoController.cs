using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardInfoController : ControllerBase
    {
        private ApplicationDbContext _context;

        public AwardInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("awardtypes")]
        public IEnumerable<AwardType> Get()
        {
            return _context.AwardTypes.AsNoTracking().AsEnumerable();
        }

        [HttpGet("awardshows")]
        public IEnumerable<AwardShow> GetShows()
        {
            return _context.AwardShows.AsNoTracking().AsEnumerable();
        }
    }
}