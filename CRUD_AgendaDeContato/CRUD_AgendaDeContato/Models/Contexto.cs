using Microsoft.EntityFrameworkCore;

namespace CRUD_AgendaDeContato.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Contato> Contato { get; set; }
    }
}
