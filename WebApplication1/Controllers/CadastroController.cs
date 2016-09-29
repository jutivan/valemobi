using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valemobi.Models;

namespace Valemobi.Controllers
{
    public class CadastroController : Controller
    {
        public static List<Mercadoria> merc = new List<Mercadoria>();
        public ActionResult PagCadastro()
        {
            return View("Cadastrar");
        }

        public ActionResult CadastrarOperacao(String nome, String codigo, String tipo, String quantidade, String preco, String tipoNegocio)
        {
            double p = Convert.ToDouble(preco);
            int q = Convert.ToInt32(quantidade);
            Mercadoria a = new Mercadoria(nome, codigo, tipo, q, p, tipoNegocio);
            merc.Add(a);
            return View("Cadastrado", merc);
        }

    }
}