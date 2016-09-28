using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Valemobi.Models
{
    public class Mercadoria
    {
        private String nome { get; set; }
        private int quantidade { get; set; }
        private double preco { get; set; }
        private String codigo { get; set; }
    }
}