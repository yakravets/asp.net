using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooms.API.Models
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public int MinCountGamers { get; set; }        
        public int MinAge { get; set; }
        public double Rating { get; set; }
        
        public string PictureUrl { get; set; }
    }
}
