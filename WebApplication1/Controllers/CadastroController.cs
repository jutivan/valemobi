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
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd;
        static String conString = "SERVER=localhost;" + "DATABASE=vmobi;" + "UID=****;" + "PASSWORD=*****;";


        public ActionResult PagCadastro()
        {
            return View("Cadastrar");
        }

        public ActionResult CadastrarOperacao(String nome, String codigo, String tipo, String quantidade, String preco, String tipoNegocio)
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            int p = Convert.ToInt32(preco);
            int q = Convert.ToInt32(quantidade);
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO tb_transacao( ID_MERCADORIA,TP_MERCADORIA,NM_MERCADORIA,QT_MERCADORIA,VL_TRANSACAO,TP_TRANSACAO) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";
                cmd.Parameters.AddWithValue("@param1", codigo);
                cmd.Parameters.AddWithValue("@param2", tipo);
                cmd.Parameters.AddWithValue("@param3", nome);
                cmd.Parameters.AddWithValue("@param4", q);
                cmd.Parameters.AddWithValue("@param5", p);
                cmd.Parameters.AddWithValue("@param6", tipoNegocio);
                
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return View("Cadastrar");
            }
            finally
            {
                con.Close();
            }


            return View("Sucesso");
        }

        public ActionResult ListarOperacoes()
        {
            List<Mercadoria> merca = new List<Mercadoria>();
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM tb_transacao";
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mercadoria m = new Mercadoria();
                    m.codigo = reader["ID_MERCADORIA"].ToString();
                    m.tipo = reader["TP_MERCADORIA"].ToString();
                    m.nome = reader["NM_MERCADORIA"].ToString();
                    m.quantidade = Convert.ToInt32(reader["QT_MERCADORIA"].ToString());
                    m.preco = Convert.ToInt32(reader["VL_TRANSACAO"].ToString());
                    m.tipoNegocio = reader["TP_TRANSACAO"].ToString();
                    merca.Add(m);
                }

            }
            catch (MySqlException e)
            {
                return View("Index");
            }
            finally
            {
                con.Close();
            }
            return View("ListaOperacoes", merca);

        }



    }
}