using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rooms.API.Data;
using Rooms.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooms.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndexController : ControllerBase
    {
        private readonly _AppContext _dbContext;
        private readonly MapperConfiguration cfg;
        private readonly Mapper mapper;

        public IndexController(_AppContext dbContext)
        {
            _dbContext = dbContext;
            cfg = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>());
            mapper = new AutoMapper.Mapper(cfg);
        }

        [HttpGet]
        public IEnumerable<RoomDTO> Index()
        {
            return mapper.Map<List<RoomDTO>>(_dbContext.Rooms.ToList());
        }
    }
}
