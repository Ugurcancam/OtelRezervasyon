using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OtelRezervasyon.Entity.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string AdSoyad { get; set; }
        public string? City { get; set;}
    } 
}