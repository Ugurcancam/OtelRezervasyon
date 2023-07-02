using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entity.Concrete
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}