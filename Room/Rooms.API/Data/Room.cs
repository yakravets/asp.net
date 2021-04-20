using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rooms.API.Data
{
    public class Room
    {
        [Key]
        public int Id{ get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        [MinLength(1)]
        public int MinCountGamers { get; set; }

        [Required]
        public int MinAge { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        public int LevelOfDifficulty { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        public int LevelOfFear { get; set; }

        [MaxLength(5)]
        [MinLength(0)]
        public double Rating { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Address { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }

        public string PictureUrl { get; set; }
    }
}
