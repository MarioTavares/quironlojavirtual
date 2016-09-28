using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.V2.Controllers
{
    public class MenuController : Controller
    {
        //
        private MenuRepositorio _repositorio;
      

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterEsportes()
        {


            _repositorio = new MenuRepositorio();

            var cat = _repositorio.Obtercategorias();

            var categoria = from c in cat

                            select new
                            {
                                c.CategoriaDescricao,
                                CategoriaDescricaoSeo = c.CategoriaDescricao.ToSeoUrl(),
                                c.CategoriaCodigo

                            };

            return Json(categoria, JsonRequestBehavior.AllowGet);
        }



        public JsonResult ObterMarcas()
        {

            _repositorio = new MenuRepositorio();

            var ListaMarcas = _repositorio.ObterMarcas();
            var marcas = from m in ListaMarcas
                         select new
                         {
                          MarcaDescricaoSeo = m.MarcaDescricao,
                          MarcaDescricao = m.MarcaDescricao.ToSeoUrl(),
                          m.MarcaCodigo
                         };
                                 

              return Json(marcas, JsonRequestBehavior.AllowGet);


         

        }


        public JsonResult ClubesNacionais()
        {

            _repositorio = new MenuRepositorio();

            var ListaNacionais = _repositorio.ObterNacionais();
            var nacionais = from m in ListaNacionais
                         select new
                         {
                            ClubeCodigo =m.LinhaCodigo,
                            ClubeSeo = m.LinhaDescricao.ToSeoUrl(),
                            Clube = m.LinhaDescricao
                             };


            return Json(nacionais, JsonRequestBehavior.AllowGet);

        }


        public JsonResult ClubesInternacionais()
        {

            _repositorio = new MenuRepositorio();

            var ListaInternacionais = _repositorio.ObterInternacionais();
            var internacionais = from m in ListaInternacionais
                                 select new
                                 {
                                     ClubeCodigo = m.LinhaCodigo,
                                     ClubeSeo = m.LinhaDescricao.ToSeoUrl(),
                                     Clube = m.LinhaDescricao

                                 };

            return Json(internacionais, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Selecoes()
        {

            _repositorio = new MenuRepositorio();

            var Listaselecoes = _repositorio.ObterSelecoes();
           var  Selecoes = from m in Listaselecoes
                       select new
                       {
                          SelecaoCodigo = m.LinhaCodigo,
                          SelecaoSeo = m.LinhaDescricao.ToSeoUrl(),
                          Selecao = m.LinhaDescricao
                       };
           return Json(Selecoes, JsonRequestBehavior.AllowGet);
        }




	}

   



}