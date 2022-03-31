using System.Net;
using System.Threading.Tasks;
using api2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api2.Models;


namespace api2.Controllers 
{
    [Controller]
    [Route("[controller]")]

    public class PessoaController : ControllerBase
    {
        private DataContext dc;

        public PessoaController(DataContext context)
        {
            this.dc = context;

        }

        [HttpPost("api")]
        public async Task<ActionResult> cadastrar([FromBody] Pessoa p)
        {
            dc.pessoa.Add(p);
            await dc.SaveChangesAsync();
            return Created("Objeto pessoa",p);

        }

         [HttpGet("oi")]
        public string oi ()
        {
            return "Hello Word";
        }
        
    }
}