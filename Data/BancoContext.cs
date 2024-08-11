using Microsoft.EntityFrameworkCore;
using WebProject_C_.Models;

namespace WebProject_C_
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        // Defina DbSet para cada entidade/tabela que deseja mapear para o banco de dados
        public DbSet<ContatoModel> contatos{ get; set; }

        // Se tiver mais entidades, adicione aqui
        // public DbSet<AnotherEntity> AnotherEntities { get; set; }

        // Opcional: Configuração adicional do modelo
       
    }
}
