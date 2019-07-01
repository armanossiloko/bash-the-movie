using BTM.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Settings
{
    public class ApplicationInfo : IApplicationInfo
    {
        public string AppName { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string Residence { get; set; }
        public string Phone { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
    }
}
