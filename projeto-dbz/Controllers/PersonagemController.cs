using Microsoft.AspNetCore.Mvc;
using ProjetoDBZ.Models;

namespace ProjetoDBZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public PersonagemController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        } 
        
    }
}