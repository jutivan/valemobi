namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vmobi.tb_transacao")]
    public partial class Transacao
    {
        [Key]
        public int ID_TRANSACAO { get; set; }

        [Required]
        [StringLength(5)]
        [Column("ID_MERCADORIA")]
        public string codigoMercadoria { get; set; }

        [Required]
        [StringLength(20)]
        [Column("TP_MERCADORIA")]
        public string tipoMercadoria { get; set; }

        [Required]
        [StringLength(100)]
        [Column("NM_MERCADORIA")]
        public string nomeMercadoria { get; set; }

        [Column("QT_MERCADORIA")]
        public decimal quantidade { get; set; }

        [Column("VL_TRANSACAO")]
        public decimal valorTransacao { get; set; }

        [Required]
        [StringLength(6)]
        [Column("TP_TRANSACAO")]
        public string tipoTransacao { get; set; }
    }
}
