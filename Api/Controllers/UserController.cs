using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Getusers()
        {
            var users = await _repo.GetUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _repo.GetUserByIdAsync(id);
        }

    }
}