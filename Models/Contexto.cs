using Microsoft.EntityFrameworkCore;

namespace ProjetoCRUDSQLite.Models
{
    public class Contexto : DbContext
    {
        //public Contexto(DbSet<Aviao> avioes) { }
        
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { } 

        public  DbSet<Aviao> Avioes { get; set; }
        
    }
    
    
}
