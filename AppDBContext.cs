using Microsoft.EntityFrameworkCore;

namespace projetocodefirst
{
        public class AppDBContext : DbContext
    {
        //mapeamento da entidade produto para a tabela produto
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=MACORATI;" +
            "Initial catalog=EFCoreDB; Integrated Security=True");
    }
}