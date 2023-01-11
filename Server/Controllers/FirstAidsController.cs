using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PNRT.Server.Data;
using PNRT.Shared.Entites;

namespace PNRT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstAidsController : ControllerBase
    {
        private readonly AddDbContext _context;

        public FirstAidsController(AddDbContext context)
        {
            _context = context;
        }

        // GET: api/FirstAids
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FirstAid>>> GetFirstAids()
        {
            return await _context.FirstAids.ToListAsync();
        }

        // GET: api/FirstAids/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FirstAid>> GetFirstAid(int id)
        {
            var firstAid = await _context.FirstAids.FindAsync(id);

            if (firstAid == null)
            {
                return NotFound();
            }

            return firstAid;
        }

        // PUT: api/FirstAids/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFirstAid(int id, FirstAid firstAid)
        {
            if (id != firstAid.Id)
            {
                return BadRequest();
            }

            _context.Entry(firstAid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FirstAidExists(id))
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

        // POST: api/FirstAids
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FirstAid>> PostFirstAid(FirstAid firstAid)
        {
            _context.FirstAids.Add(firstAid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFirstAid", new { id = firstAid.Id }, firstAid);
        }

        // DELETE: api/FirstAids/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFirstAid(int id)
        {
            var firstAid = await _context.FirstAids.FindAsync(id);
            if (firstAid == null)
            {
                return NotFound();
            }

            _context.FirstAids.Remove(firstAid);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FirstAidExists(int id)
        {
            return _context.FirstAids.Any(e => e.Id == id);
        }
    }
}
