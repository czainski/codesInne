using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Db _context;

        public ProductController(Db context)
        {
            _context = context;

            if (_context.Products.Count() == 0)
            {
                _context.Products.Add(new Product { Name = "Product1" });
                _context.Products.Add(new Product { Name = "Product2" });
                _context.Products.Add(new Product { Name = "Product3" });
                _context.Products.Add(new Product { Name = "Product4" });
                _context.SaveChanges();
            }
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get() =>
                   await _context.Products.ToListAsync();
        
        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var todoItem = await _context.Products.FindAsync(id);

            if (todoItem == null)
                  return NotFound();
  
            _context.Products.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}