using UNIP_PIMVIII_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace UNIP_PIMVIII_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Pessoa> ID { get; set; }
        public DbSet<Pessoa> NOME { get; set; }
        public DbSet<Pessoa> CPF { get; set; }
        public DbSet<Pessoa> ENDERECO { get; set; }

     }



}
