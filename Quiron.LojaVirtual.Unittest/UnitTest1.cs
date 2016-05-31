using System;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using Quiron.LojaVirtual.Dominio;

using System.Web.Mvc;


namespace Quiron.LojaVirtual.Unittest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {
        }



        public void TestedePaginacao()
        {



            HtmlHelper html = null;


            Paginacao paginacao = new Paginacao
            {

                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28

            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //act

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //assert

            Assert.AreEqual(
                
                @"<a class=""btn btn-default"" href=""pagina1"">1</a>
                  +@<a class=""btn btn-default btn-primary selected"" href=""pagina2"">2</a>
                    +<a class=""btn btn-default"" href=""pagina3"">3</a>", resultado.ToString()
                
                );        
                
                

        }


    }






}
