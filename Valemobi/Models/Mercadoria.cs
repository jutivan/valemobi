using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Valemobi.Models
{
    public class Mercadoria
    {
        public String nome { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }
        public String codigo { get; set; }
        public String tipo { get; set; }
        public String tipoNegocio { get; set; }

        public Mercadoria(String nome, String codigo, String tipo, int quantidade, double preco, String tipoNegocio)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.tipo = tipo;
            this.quantidade = quantidade;
            this.preco = preco;
            this.tipoNegocio = tipoNegocio;
        }
    }

    
}