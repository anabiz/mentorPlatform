using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentorsController : ControllerBase
    {
        private readonly IMentorRepository _repo;

        public MentorsController(IMentorRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mentor>>> GetMentors()
        {
            var mentors = await _repo.GetMentorsAsync();
            return Ok(mentors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mentor>> GetMentor(int id)
        {
            return await _repo.GetMentorByIdAsync(id);
        }
    }
}