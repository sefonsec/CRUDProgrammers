using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDProgrammers.Models;

namespace CRUDProgrammers.Data
{
    public class Context : IdentityDbContext<UsuarioDaAplicacao>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<PessoaModel> Pessoas { get; set; }
    }
}