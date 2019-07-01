using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private IDataService<Language> _languageService;

        public LanguagesController(IDataService<Language> languageService)
        {
            _languageService = languageService;
        }

        // GET: api/Language
        [HttpGet]
        public IEnumerable<Language> Get()
        {
            return _languageService.Get();
        }

        // GET: api/Language/5
        [HttpGet("{id}")]
        public Language Get(int id)
        {
            return _languageService.Get(id);
        }
    }
}
