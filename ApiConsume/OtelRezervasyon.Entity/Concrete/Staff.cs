using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entity.Concrete
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Social1 { get; set; }
        public string Social2 { get; set; }
        public string Social3 { get; set; }

    }
}