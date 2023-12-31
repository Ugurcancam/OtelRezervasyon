using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.Dto.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int Id { get; set; }
        public string RoomCoverImage { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }   
    }
}