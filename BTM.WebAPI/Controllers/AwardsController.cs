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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsController : ControllerBase
    {
        private ICRData<Award> _awardData;

        public AwardsController(ICRData<Award> awardData)
        {
            _awardData = awardData;
        }

        // GET api/images/5
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Award> Get()
        {
            return _awardData.Get();
        }

        // GET api/images/5
        [HttpGet("{id}")]
        //[AllowAnonymous]
        public Award Get(int id)
        {
            return _awardData.Get(x => x.MediaID == id);
        }

        // POST api/images
        [HttpPost]
        public Award Post(AwardInputModel obj)
        {
            Award award = new Award
            {
                AwardShowID = obj.AwardShowID,
                AwardTypeID = obj.AwardTypeID,
                MediaID = obj.MediaID,
                Name = obj.Name,
                Year = obj.Year
            };

            return _awardData.Add(award);
        }
    }
}