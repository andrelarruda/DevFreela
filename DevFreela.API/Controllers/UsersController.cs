using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkObjectResult("UsersController!");
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
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
