using Final1.Data;
using Final1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyInfoController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public MyInfoController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public ActionResult<MyInfo> Create([FromBody] MyInfo info)
        {
            _appDbContext.MyInfos.Add(info);
            _appDbContext.SaveChanges();
            return Ok(info);
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<MyInfo>> GetAll()
        {
            return _appDbContext.MyInfos.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<MyInfo> GetById(int? id)
        { 
            var student = _appDbContext.MyInfos.Find(id);
            return Ok(student);
        }

        [HttpPut("{id:int}")]
        public ActionResult<MyInfo> Update([FromBody] MyInfo info)
        {
            _appDbContext.MyInfos.Update(info);
            _appDbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            var info = _appDbContext.MyInfos.Find(id);

            if (info == null)
            {
                return NotFound(new { Message = $"Person with ID {id} not found." });
            }

            _appDbContext.MyInfos.Remove(info);
            _appDbContext.SaveChanges();
            return Ok();
        }

    }
}
