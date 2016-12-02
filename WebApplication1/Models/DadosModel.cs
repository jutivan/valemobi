namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DadosModel : DbContext
    {
        public DadosModel()
            : base("name=DadosModel")
        {
        }

        public virtual DbSet<Transacao> tb_transacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>()
                .Property(e => e.codigoMercadoria)
                .IsUnicode(false);

            modelBuilder.Entity<Transacao>()
                .Property(e => e.tipoMercadoria)
                .IsUnicode(false);

            modelBuilder.Entity<Transacao>()
                .Property(e => e.nomeMercadoria)
                .IsUnicode(false);

            modelBuilder.Entity<Transacao>()
                .Property(e => e.tipoTransacao)
                .IsUnicode(false);
        }
    }
}
