using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1.Models
{
    public class DBCon
    {
        protected SqlConnection con;

        public bool Abrir(string Conexao = "DefaultConnection")
        {
            con = new SqlConnection(@WebConfigurationManager.ConnectionStrings[Conexao].ToString());

            try
            {

                if (!con.State.ToString().Equals("Open"))
                {
                    con.Open();
                }
                return true;

            }
            catch (SqlException e)
            {
                return false;
            }
        }


        public bool Fechar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}