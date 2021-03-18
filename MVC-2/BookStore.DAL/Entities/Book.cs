using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int YearPublication { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public Author Author { get; set; }
    }
}
