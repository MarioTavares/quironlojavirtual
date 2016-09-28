using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
   public class CategoriaRepositorio
    {

       private readonly EfDbContext _context = new EfDbContext();

       public IEnumerable<Categoria> ObterCategorias()
   {

       return _context.categorias.OrderBy(c => c.CategoriaDescricao);


   }


     
    }
}
