using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rooms.API.Data;
using Rooms.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rooms.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly _AppContext _dbContext;
        private readonly MapperConfiguration cfg;
        private readonly Mapper mapper;

        public RoomController(_AppContext dbContext)
        {
            _dbContext = dbContext;
            cfg = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDetailDTO>());
            mapper = new Mapper(cfg);
        }

        [HttpGet]
        public RoomDetailDTO Get(int id)
        {
            return mapper.Map<RoomDetailDTO>(_dbContext.Rooms.ToList().FirstOrDefault(x => x.Id == id));
        }
    }
}
