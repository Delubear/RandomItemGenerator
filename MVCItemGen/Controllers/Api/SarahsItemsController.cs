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
        public async Task<IActionResult> PutSarahsItem([FromRoute] string id, [FromForm] SarahsItem sarahsItem)
        {            
            SarahsItem itemToUpdate = _context.SarahsItems.FirstOrDefault(i => i.Id == id);
            
            
            itemToUpdate.Name = sarahsItem.Name;
            itemToUpdate.Description = sarahsItem.Description;
            itemToUpdate.DateAdded = sarahsItem.DateAdded;
            itemToUpdate.DateCompleted = sarahsItem.DateCompleted;
            itemToUpdate.TypeOfItem = sarahsItem.TypeOfItem;
            if(itemToUpdate.DateCompleted == null)
            {
                //itemToUpdate.DateCompleted = DateTime.Today;
            }
            
            // sarahsItem.DateCompleted = DateTime.Today;

            //_context.SarahsItems.Update(itemToUpdate);
            //_context.SarahsItems.Update(sarahsItem);
            //_context.Update(itemToUpdate);
            //_context.Update(sarahsItem);
            //_context.Entry(sarahsItem).State = EntityState.Modified;
            //_context.Entry(itemToUpdate).State = EntityState.Modified;
            // _context.SarahsItems.(itemToUpdate);
            await _context.SaveChangesAsync();

            return Ok(itemToUpdate);
        }

        // POST: api/SarahsItems
        [HttpPost]
        public async Task<IActionResult> PostSarahsItem([FromForm] SarahsItem sarahsItem)
        {

            SarahsItem newItem = new SarahsItem();
            newItem.Id = sarahsItem.Id;
            newItem.Name = sarahsItem.Name;
            newItem.Description = sarahsItem.Description;
            newItem.TypeOfItem = sarahsItem.TypeOfItem;
            newItem.DateAdded = DateTime.Today;

            _context.SarahsItems.Add(newItem);
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