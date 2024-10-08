﻿using DevFreela.API.Entities;
using DevFreela.API.Models;
using DevFreela.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DevFreelaDbContext _context;

        public UsersController(DevFreelaDbContext context)
        {
            _context = context;
        }

        // GET api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkObjectResult("UsersController!");
        }

        [HttpPost("{Id}/skills")]
        public IActionResult PostSkills(int id, UserSkillsInputModel model)
        {
            var userSkills = model.SkillIds.Select(s => new UserSkill(id, s)).ToList();

            _context.AddRange(userSkills);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users
                .Include(u => u.Skills)
                    .ThenInclude(u => u.Skill)
                .SingleOrDefault(x => x.Id == id);

            if (user == null) {
                return NotFound();
            }
            return Ok(UserViewModel.FromEntity(user));
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.FullName == model.FullName);
            if (user != null) {
                return BadRequest("User already exists.");
            }

            var entity = model.ToEntity();
            var savedEntity = _context.Users.Add(entity);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = savedEntity.Entity.Id}, model);
        }

        // PUT api/users/1234/profile-picture
        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            // processar a imagem

            return Ok(description);
        }
    }
}
