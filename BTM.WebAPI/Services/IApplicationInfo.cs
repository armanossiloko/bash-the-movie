using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public interface IApplicationInfo
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Residence { get; set; }
        string Phone { get; set; }
    }
}
