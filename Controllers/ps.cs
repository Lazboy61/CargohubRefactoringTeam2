using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;


    [ApiController]
    [Route("api/test")]
    public class ItemController : ControllerBase
    {
        private readonly ModelContext _context;

        public ItemController(ModelContext context)
        {
            _context = context;
        }

        

        // POST: api/Item
        [HttpPost]
        public async Task<IActionResult> PostItem(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return Ok();
        }

        
    }
