using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OracleClient;

namespace Valemobi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       /* public ActionResult Conectar()
        {
            OracleConnection c = new OracleConnection();
            c.ConnectionString =
            "Data Source = oracle.fiap.com.br:1521:ORCL; " +
            "User id=OPS$RM75972;" +
            "Password=080488;";
            try
            {
                c.Open();
                c.Close();

                return View("Conectado");
            }
            catch (OracleException e)
            {
                string errorMessage = "Code: " + e.Code + "\n" +
                           "Message: " + e.Message;

                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                log.Source = "My Application";
                log.WriteEntry(errorMessage);
                Console.WriteLine("An exception occurred. Please contact your system administrator.");
            }
            
            
            return View("Index");
        }
        */
    }
}