using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCItemGen.Model;

namespace MVCItemGen.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/SarahsItems")]
    public class SarahsItemsController : Controller
    {
        private readonly SarahDBContext _context;

        public SarahsItemsController(SarahDBContext context)
        {
            _context = context;
        }

        // GET: api/SarahsItems
        [HttpGet]
        public IEnumerable<SarahsItem> GetSarahsItems()
        {
            return _context.SarahsItems;
        }

        // GET: api/SarahsItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSarahsItem([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sarahsItem = await _context.SarahsItems.SingleOrDefaultAsync(m => m.Id == id);

            if (sarahsItem == null)
            {
                return NotFound();
            }

            return Ok(sarahsItem);
        }

        // PUT: api/SarahsItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSarahsItem([FromRoute] string id, [FromBody] SarahsItem sarahsItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sarahsItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(sarahsItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SarahsItemExists(id))
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

        // POST: api/SarahsItems
        [HttpPost]
        public async Task<IActionResult> PostSarahsItem([FromBody] SarahsItem sarahsItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SarahsItems.Add(sarahsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSarahsItem", new { id = sarahsItem.Id }, sarahsItem);
        }

        // DELETE: api/SarahsItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {

            var sarahsItem = await _context.SarahsItems.SingleOrDefaultAsync(m => m.Id == id);
            if (sarahsItem == null)
            {
                return NotFound();
            }

            _context.SarahsItems.Remove(sarahsItem);
            await _context.SaveChangesAsync();

            return Ok(sarahsItem);
        }

        private bool SarahsItemExists(string id)
        {
            return _context.SarahsItems.Any(e => e.Id == id);
        }
    }
}