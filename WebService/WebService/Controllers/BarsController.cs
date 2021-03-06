﻿using System;
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
    public class BarsController : ControllerBase
    {
        private readonly DBContext _context;

        public BarsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Bars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bar>>> GetBar()
        {
            return await _context.Bar.ToListAsync();
        }

        // GET: api/Bars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bar>> GetBar(Guid id)
        {
            var bar = await _context.Bar.FindAsync(id);

            if (bar == null)
            {
                return NotFound();
            }

            return bar;
        }

        // PUT: api/Bars/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBar(Guid id, Bar bar)
        {
            if (id != bar.BarID)
            {
                return BadRequest();
            }

            _context.Entry(bar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               if (!BarExists(id))
               {
                   return NotFound();
               }
               else throw;
            }

            return NoContent();
        }

        // POST: api/Bars
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Bar>> PostBar(Bar bar)
        {
            _context.Bar.Add(bar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBar", new { id = bar.BarID }, bar);
        }

        // DELETE: api/Bars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bar>> DeleteBar(Guid id)
        {
            var bar = await _context.Bar.FindAsync(id);
            if (bar == null)
            {
                return NotFound();
            }

            _context.Bar.Remove(bar);
            await _context.SaveChangesAsync();

            return bar;
        }

        private bool BarExists(Guid id)
        {
            return _context.Bar.Any(e => e.BarID == id);
        }
    }
}
