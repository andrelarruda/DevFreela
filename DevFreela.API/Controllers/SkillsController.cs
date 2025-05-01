using DevFreela.Core.Entities;
using DevFreela.Core.Models;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Core.Controllers
{
    [Route("api/skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {

        private readonly DevFreelaDbContext _context;

        public SkillsController(DevFreelaDbContext context)
        {
            _context = context;
        }
        // GET api/skills
        [HttpGet]
        public IActionResult GetAll()
        {
            var skills = _context.Skills.Select(SkillViewModel.FromEntity).ToList();
            return Ok(skills);
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post(CreateSkillInputModel model)
        {
            var skill = model.ToEntity();

            _context.Skills.Add(skill);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
