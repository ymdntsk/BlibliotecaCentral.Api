using BlibliotecaCentral.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlibliotecaCentral.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CadastarLivro> CadastarLivros { get; set; } 

    }
}

