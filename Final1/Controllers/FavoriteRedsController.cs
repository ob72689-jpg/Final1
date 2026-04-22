using Final1.Data;
using Final1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteRedsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FavoriteRedsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public ActionResult<FavoriteReds> Create([FromBody] FavoriteReds redsPlayer)
        {
            _appDbContext.FavoriteReds.Add(redsPlayer);
            _appDbContext.SaveChanges();
            return Ok(redsPlayer);
        }

        [HttpGet]
        public ActionResult<IEnumerable<FavoriteReds>> GetAll()
        {
            return _appDbContext.FavoriteReds.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<FavoriteReds> GetById(int? id)
        {
            var redsPlayer = _appDbContext.FavoriteReds.Find(id);
            return Ok(redsPlayer);
        }

        [HttpPut("{id:int}")]
        public ActionResult<FavoriteReds> Update([FromBody] FavoriteReds redsPlayer)
        {
            _appDbContext.FavoriteReds.Update(redsPlayer);
            _appDbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            var redsPlayer
                = _appDbContext.FavoriteReds.Find(id);

            if (redsPlayer == null)
            {
                return NotFound(new { Message = $"Person with ID {id} not found." });
            }

            _appDbContext.FavoriteReds.Remove(redsPlayer);
            _appDbContext.SaveChanges();
            return Ok();
        }

    }
}
