﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Quiron.LojaVirtual.Web.Infraestrutura;
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Web.App_Start;


namespace Quiron.LojaVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.Add(typeof(Carrinho), new CarrinhoModelBinder());

        }
    }
}
