using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ModelBindingController : Controller
    {
        //
        // GET: /ModelBinding/
        public ActionResult Index()
        {
            return View(new Produto());
        }

        [HttpPost]

        public ActionResult Editar([Bind(Include="Nome")]Produto produt)
        {

            //var produto = new Produto();

            return RedirectToAction("Index");

        }

	}
}