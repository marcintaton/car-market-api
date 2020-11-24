using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarMarket.Models;

namespace CarMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectMessagesController : ControllerBase
    {
        private readonly CarMarketDBContext _context;

        public DirectMessagesController(CarMarketDBContext context)
        {
            _context = context;
        }

        // GET: api/DirectMessages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DirectMessage>>> GetDirectMessages()
        {
            return await _context.DirectMessages.ToListAsync();
        }

        // GET: api/DirectMessages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DirectMessage>> GetDirectMessage(int id)
        {
            var directMessage = await _context.DirectMessages.FindAsync(id);

            if (directMessage == null)
            {
                return NotFound();
            }

            return directMessage;
        }

        // PUT: api/DirectMessages/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirectMessage(int id, DirectMessage directMessage)
        {
            if (id != directMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(directMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectMessageExists(id))
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

        // POST: api/DirectMessages
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DirectMessage>> PostDirectMessage(DirectMessage directMessage)
        {
            _context.DirectMessages.Add(directMessage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDirectMessage", new { id = directMessage.Id }, directMessage);
        }

        // DELETE: api/DirectMessages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DirectMessage>> DeleteDirectMessage(int id)
        {
            var directMessage = await _context.DirectMessages.FindAsync(id);
            if (directMessage == null)
            {
                return NotFound();
            }

            _context.DirectMessages.Remove(directMessage);
            await _context.SaveChangesAsync();

            return directMessage;
        }

        private bool DirectMessageExists(int id)
        {
            return _context.DirectMessages.Any(e => e.Id == id);
        }
    }
}
