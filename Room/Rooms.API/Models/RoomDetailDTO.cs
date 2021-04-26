using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooms.API.Models
{
    public class RoomDetailDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int MinCountGamers { get; set; }
        public int MinAge { get; set; }
        public int LevelOfDifficulty { get; set; }
        public int LevelOfFear { get; set; }
        public double Rating { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        
        public string PictureUrl { get; set; }
    }
}
