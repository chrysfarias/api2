using System.Threading.Tasks;
using api2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api2.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoaController
    {
         [HttpGet("oi")]
        public string oi ()
        {
            return "Hello Word";
        }
        
    }
}