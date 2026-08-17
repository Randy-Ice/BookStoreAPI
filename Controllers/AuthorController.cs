using BookStoreAPI.Data;
using BookStoreAPI.DTOs;
using BookStoreAPI.Models;

using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase

    {
        readonly Database _dbContext;
        public AuthorController(Database database)
        {
            _dbContext = database;
        }
        [EnableQuery()]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var author = await _dbContext.Authors.ToListAsync();
            return Ok(author.Adapt<IEnumerable<AuthorGetDTO>>());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var artist = await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (artist == null)
            {
                return NotFound();
            }
            return Ok(artist.Adapt<AuthorGetDTO>());

        }
        [HttpPost]
        public async Task<IActionResult> Create(AuthorPostDTO createAuthor)
        {
            var createdAuthor = createAuthor.Adapt<Author>();
            await _dbContext.Authors.AddAsync(createdAuthor);
            await _dbContext.SaveChangesAsync();
            var authorDto = createdAuthor.Adapt<AuthorGetDTO>();
            return CreatedAtAction(nameof(GetById), new { id = createdAuthor.Id }, authorDto);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, AuthorUpdateDTO artistDto)
        {
            var author = await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            artistDto.Adapt(author);

            //Save changes
            await _dbContext.SaveChangesAsync();
            return NoContent();


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var author = await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            _dbContext.Authors.Remove(author);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }




    }

}
