using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Valemobi.Controllers
{
    public class CadastroController : Controller
    {
        public static List<Mercadoria> merc = new List<Mercadoria>();
        public DBCon db = new DBCon();

        public ActionResult PagCadastro()
        {
            return View("Cadastrar");
        }

        public ActionResult Listar()
        {
            return View("ListaOperacoes", merc);
        }

        public ActionResult CadastrarOperacao(String nome, String codigo, String tipo, String quantidade, String preco, String tipoNegocio)
        {
            double p = Convert.ToDouble(preco);
            int q = Convert.ToInt32(quantidade);
            Mercadoria a = new Mercadoria(nome, codigo, tipo, q, p, tipoNegocio);
            merc.Add(a);
            return View("ListaOperacoes", merc);
        }

        public ActionResult TestCon()
        {
            bool a = db.Abrir();
            if (a.Equals(true))
            {
                a = db.Fechar();
                return View("ListaOperacoes", merc);
            }
            else
            {
                return View("Index");
            }

        }

    }
}