using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CS_1._0.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
