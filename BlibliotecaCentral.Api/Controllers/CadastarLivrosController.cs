using BlibliotecaCentral.Api.Data;
using BlibliotecaCentral.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlibliotecaCentral.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastarLivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CadastarLivrosController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> AddLivro(CadastarLivro livro)
        {
            _context.CadastarLivros.Add(livro);
            await _context.SaveChangesAsync();
            return Ok($"Livro \"{livro.Titulo}\" salvo com sucesso");
        }


        
    }
}
