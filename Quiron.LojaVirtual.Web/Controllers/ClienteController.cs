using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        [Route("teste")]
        public ActionResult Index()
        {
            return View();
        }
	}
}