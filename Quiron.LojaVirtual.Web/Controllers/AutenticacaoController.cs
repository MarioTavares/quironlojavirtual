﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class AutenticacaoController : Controller
    {

        private AdministradoresRepositorio _repositorio;
        //
        // GET: /Autenticacao/
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new Administrador());
        }
        [HttpPost]
        public ActionResult Login(Administrador administrador, string returnUrl)
        {

            _repositorio = new AdministradoresRepositorio();

            if (ModelState.IsValid)
            {
                Administrador admin = _repositorio.ObterAdministrador(administrador);

                if (admin != null)
                {

                    if (!Equals(administrador.Senha, admin.Senha))
                    {
                        ModelState.AddModelError("", "Senha não confere");
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(admin.Login, false);
                        if (Url.IsLocalUrl(returnUrl)
                             //&& returnUrl > 1
                                && returnUrl.StartsWith("/")
                                && !returnUrl.StartsWith("//")
                                && !returnUrl.StartsWith("/\\"))

                            return Redirect(returnUrl);
                    }



                }
                else
                {
                    ModelState.AddModelError("", "Administrador Não localizado!");
                }
            }

            return View(new Administrador());
        }
    }
}