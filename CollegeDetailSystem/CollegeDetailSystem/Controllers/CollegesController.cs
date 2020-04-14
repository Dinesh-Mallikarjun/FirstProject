using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollegeDetailSystem.Models;

namespace CollegeDetailSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        private readonly StudentDBContext _context;

        public CollegesController(StudentDBContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IEnumerable<College> GetCollege()
        {
            return _context.College;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCollege([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var college = await _context.College.FindAsync(id);

            if (college == null)
            {
                return NotFound();
            }

            return Ok(college);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege([FromRoute] int id, [FromBody] College college)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != college.Collegeid)
            {
                return BadRequest();
            }

            _context.Entry(college).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colleges
        [HttpPost]
        public async Task<IActionResult> PostCollege([FromBody] College college)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.College.Add(college);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollege", new { id = college.Collegeid }, college);
        }

        // DELETE: api/Colleges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollege([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var college = await _context.College.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }

            _context.College.Remove(college);
            await _context.SaveChangesAsync();

            return Ok(college);
        }

        private bool CollegeExists(int id)
        {
            return _context.College.Any(e => e.Collegeid == id);
        }
    }
}