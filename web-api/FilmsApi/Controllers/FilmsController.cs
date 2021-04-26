using FilmsApi.Data;
using FilmsApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly ApplicationContext _dbContext;

        public FilmsController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<FilmDTO> Get(int id)
        {
            if (id == null || id == 0)
            {
                return _dbContext.Films.Include(x => x.Genre).Select(x => new FilmDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Rating = x.Rating,
                    GenreId = x.Genre.Id
                });
            }

            var film = _dbContext.Films.Include(x => x.Genre).FirstOrDefault(x => x.Id == id);
            if (film == null)
            {
                return null;
            }

            return new List<FilmDTO>()
            {
               new FilmDTO
               {
                   Id = film.Id,
                   Name = film.Name,
                   Rating = film.Rating,
                   GenreId = film.Genre.Id
               }
            };
        }

        [HttpPost]
        public async Task<IActionResult> Add(FilmDTO film)
        {
            if (film == null)
            {
                return BadRequest("Bosy is empty");
            }

            _dbContext.Films.Add(new Film
            {
                Name = film.Name,
                Rating = film.Rating,
                Genre = _dbContext.Genres.FirstOrDefault(x => x.Id == film.GenreId)
            });

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id == 0)
            {
                return BadRequest("Id not found or incorect.");
            }

            var film = _dbContext.Films.FirstOrDefault(x => x.Id == id);
            if (film == null)
            {
                return NotFound("Film not found.");
            }

            _dbContext.Films.Remove(film);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FilmDTO film)
        {
            if (film == null)
            {
                return BadRequest("Body not found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Model not valid.");
            }

            var genre = _dbContext.Genres.FirstOrDefault(x => x.Id == film.GenreId);
            if (genre == null)
            {
                return BadRequest("Genre not found.");
            }

            var newFilm = new Film()
            {
                Name = film.Name,
                Genre = genre,
                Rating = film.Rating,
                Id = film.Id
            };

            _dbContext.Films.Add(newFilm);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}

// CRUD
// C - Post +
// R - Get +
// U - Put +
// D - Delete +