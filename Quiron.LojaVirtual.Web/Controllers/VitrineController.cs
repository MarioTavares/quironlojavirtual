using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        //
        // GET: /Vitrine/

        private ProdutosRepositorio _repositorio;
        public int ProdutosPorpagina= 8;

        public ActionResult ListaProdutos(int pagina = 1)
        {



            _repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
               .OrderBy(p => p.Descricao)
               .Skip((pagina - 1) * ProdutosPorpagina)
               .Take(ProdutosPorpagina),

                paginacao = new Paginacao
                {

                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorpagina,
                    ItensTotal = _repositorio.Produtos.Count()

                }

            };


          

            return View(model);
        }
	}
}