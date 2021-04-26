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
    public class GenresController : ControllerBase
    {
        private readonly ApplicationContext _dbContext;

        public GenresController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<GenreDTO> Get()
        {
            return _dbContext.Genres.Select(x => new GenreDTO() { Name = x.Name, Id = x.Id });
        }
    }
}
