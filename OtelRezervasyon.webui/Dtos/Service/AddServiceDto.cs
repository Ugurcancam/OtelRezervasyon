using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.webui.Dtos.Service
{
    public class AddServiceDto
    {
        
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }        
    }
}