using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Mercadoria
    {
        public String nome { get; set; }
        public int quantidade { get; set; }
        public int preco { get; set; }
        public String codigo { get; set; }
        public String tipo { get; set; }
        public String tipoNegocio { get; set; }

        public Mercadoria()
        {

        }

        public Mercadoria(String nome, String codigo, String tipo, int quantidade, int preco, String tipoNegocio)
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