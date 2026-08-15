using BookStoreAPI.Data;
using BookStoreAPI.DTOs;
using BookStoreAPI.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase

    {
        public readonly Database _dbContext;
        public AuthorController(Database database)
        {
            _dbContext = database;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var author = _dbContext.Authors.ToList();
            return Ok(author.Adapt<IEnumerable<AuthorGetDTO>>());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var artist = _dbContext.Authors.FirstOrDefault(x => x.Id == id);
            if (artist == null)
            {
                return NotFound();
            }
            return Ok(artist.Adapt<AuthorGetDTO>());

        }
        [HttpPost]
        public IActionResult Create(AuthorPostDTO createAuthor)
        {
            var createdAuthor = createAuthor.Adapt<Author>();
            _dbContext.Authors.Add(createdAuthor);
            _dbContext.SaveChanges();
            var authorDto = createdAuthor.Adapt<AuthorGetDTO>();
            return CreatedAtAction(nameof(GetById), new { id = createdAuthor.Id }, authorDto);

        }


    }

}
