using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using MySql.Data.MySqlClient;

namespace Valemobi.Controllers
{
    public class CadastroController : Controller
    {

        public ActionResult PagCadastro()
        {
            return View("Cadastrar");
        }

        public ActionResult CadastrarTransacao(String nome, String codigo, String tipo, String quantidade, String preco, String tipoNegocio)
        {
            DadosModel db = new DadosModel();
            Transacao transacao = new Transacao();
            transacao.nomeMercadoria = nome;
            transacao.codigoMercadoria = codigo;
            transacao.quantidade = Convert.ToInt32(quantidade);
            transacao.tipoMercadoria = tipo;
            transacao.tipoTransacao = tipoNegocio;
            transacao.valorTransacao = Convert.ToInt32(preco);
            try
            {
                db.tb_transacao.Add(transacao);
                db.SaveChanges();
            }
            catch (MySqlException)
            {
                return View("Cadastrar");
            }
            return View("Sucesso");


        }

        public ActionResult ListarTransacoes()
        {
            DadosModel db = new DadosModel();
            db.tb_transacao.ToList();
            return View("Listar", db.tb_transacao.ToList());
        }
       



    }
}