using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.Entidade.Vitrine;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
   public class EfDbContext : DbContext
    {

       public DbSet<Produto> Produtos { get; set; }
       public DbSet<Administrador> Administradores { get; set; }

       public DbSet<Categoria> categorias { get; set; }

       public DbSet<MarcaVitrine> MarcaVitrine { get; set; }

       //public DbSet<Clubes> Clubes { get; set; }

       public DbSet<ClubesNacionais> ClubesNaciionais { get; set; }

       public DbSet<ClubesInternacionais> ClubesInternacionais { get; set; }

       public DbSet<Selecoes> Selecoes { get; set; }

       public DbSet<FaixaEtaria> FaixasEtarias { get; set; }
       public DbSet<Genero> Generos { get; set; }
       public DbSet<Grupo> Grupos { get; set; }
       public DbSet<Marca> Marcas { get; set; }
       public DbSet<Modalidade> Modalidades { get; set; }




       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           modelBuilder.Entity<Produto>().ToTable("Produtos");
           modelBuilder.Entity<Administrador>().ToTable("Administradores");


       }

    }
}
