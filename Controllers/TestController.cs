using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;


    [ApiController]
    [Route("Client")]
    public class ClientController: ControllerBase
    {
        private readonly ModelContext _context;
        private readonly ICRUDinterface<Client> _CRUDinterface;

        public ClientController(ICRUDinterface<Client> CRUDinterface,ModelContext context)
        {
            _CRUDinterface = CRUDinterface;
            _context = context;
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
           

            return Ok("it worked");
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
           
            List<Client> holder =_CRUDinterface.GetAll();
            return Ok(holder);
        }
        [HttpPost("Post")]
        public  async Task<IActionResult> Post([FromBody] Client Client)
        {
            _CRUDinterface.Post(Client);
            return Ok(Client);
            
        


        }
        
    }
