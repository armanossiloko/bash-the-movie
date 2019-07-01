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
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlotKeywordsController : ControllerBase
    {
        private ICRData<PlotKeywords> _plotData;
        private ApplicationDbContext _context;

        public PlotKeywordsController(ICRData<PlotKeywords> plotData, ApplicationDbContext context)
        {
            _plotData = plotData;
            _context = context;
        }

        // GET: api/PlotKeywords/5
        [HttpGet]
        public IEnumerable<PlotKeywords> Get()
        {
            return _plotData.Get();
        }

        // POST: api/PlotKeywords
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PlotKeywords Post(PlotInputModel obj)
        {
            PlotKeywords model = new PlotKeywords
            {
                KeywordName = obj.KeywordName
            };
            var returned = _plotData.Add(model);
            _context.SaveChanges();

            _context.MediaPlotKeywords.Add(new MediaPlotKeywords
            {
                KeywordID = returned.KeywordID,
                MediaID = obj.MediaID
            });
            _context.SaveChanges();

            return model;
        }
    }
}