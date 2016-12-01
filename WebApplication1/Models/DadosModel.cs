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

        public virtual DbSet<tb_transacao> tb_transacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_transacao>()
                .Property(e => e.ID_MERCADORIA)
                .IsUnicode(false);

            modelBuilder.Entity<tb_transacao>()
                .Property(e => e.TP_MERCADORIA)
                .IsUnicode(false);

            modelBuilder.Entity<tb_transacao>()
                .Property(e => e.NM_MERCADORIA)
                .IsUnicode(false);

            modelBuilder.Entity<tb_transacao>()
                .Property(e => e.TP_TRANSACAO)
                .IsUnicode(false);
        }
    }
}
