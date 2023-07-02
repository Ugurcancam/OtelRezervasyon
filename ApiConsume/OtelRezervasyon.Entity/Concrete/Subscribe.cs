using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entity.Concrete
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
    }
}