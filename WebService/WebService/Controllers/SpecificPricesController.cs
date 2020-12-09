using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Base_Classes;
using WebService.Data;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecificPricesController : ControllerBase
    {
        private readonly DBContext _context;

        public SpecificPricesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/SpecificPrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecificPrice>>> GetSpecificPrice()
        {
            return await _context.SpecificPrice.ToListAsync();
        }

        // GET: api/SpecificPrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpecificPrice>> GetSpecificPrice(int id)
        {
            var specificPrice = await _context.SpecificPrice.FindAsync(id);

            if (specificPrice == null)
            {
                return NotFound();
            }

            return specificPrice;
        }

        // PUT: api/SpecificPrices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecificPrice(int id, SpecificPrice specificPrice)
        {
            if (id != specificPrice.SpecificPriceID)
            {
                return BadRequest();
            }

            _context.Entry(specificPrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecificPriceExists(id))
                {
                    return NotFound();
                }
                else throw;
            }

            return NoContent();
        }

        // POST: api/SpecificPrices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SpecificPrice>> PostSpecificPrice(SpecificPrice specificPrice)
        {
            _context.SpecificPrice.Add(specificPrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecificPrice", new { id = specificPrice.SpecificPriceID }, specificPrice);
        }

        // DELETE: api/SpecificPrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecificPrice(int id)
        {
            var specificPrice = await _context.SpecificPrice.FindAsync(id);
            if (specificPrice == null)
            {
                return NotFound();
            }

            _context.SpecificPrice.Remove(specificPrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SpecificPriceExists(int id)
        {
            return _context.SpecificPrice.Any(e => e.SpecificPriceID == id);
        }
    }
}
