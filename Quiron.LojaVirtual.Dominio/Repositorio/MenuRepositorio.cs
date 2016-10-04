using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.Entidade.Vitrine;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class MenuRepositorio
    {

        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Categoria> Obtercategorias()
        {
            return _context.categorias.OrderBy(c => c.CategoriaDescricao);
        }


        public IEnumerable<MarcaVitrine> ObterMarcas()
        {
            return _context.MarcaVitrine.OrderBy(m => m.MarcaDescricao);
        }

        public IEnumerable<ClubesNacionais> ObterNacionais()
        {
            return _context.ClubesNaciionais.OrderBy(cl => cl.LinhaDescricao);
        }


        public IEnumerable<ClubesInternacionais> ObterInternacionais()
        {

            return _context.ClubesInternacionais.OrderBy(ci => ci.LinhaDescricao);

        }

        public IEnumerable<Selecoes> ObterSelecoes()
        {
            return _context.Selecoes.OrderBy(s => s.LinhaDescricao);

        }

        public IEnumerable<Genero> ObterGenero()
        {
            return _context.Generos.OrderBy(g => g.GeneroDescricao);

        }


    }
}
