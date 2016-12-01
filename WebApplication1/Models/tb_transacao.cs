namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vmobi.tb_transacao")]
    public partial class tb_transacao
    {
        [Key]
        public int ID_TRANSACAO { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_MERCADORIA { get; set; }

        [Required]
        [StringLength(20)]
        public string TP_MERCADORIA { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_MERCADORIA { get; set; }

        public decimal QT_MERCADORIA { get; set; }

        public decimal VL_TRANSACAO { get; set; }

        [Required]
        [StringLength(6)]
        public string TP_TRANSACAO { get; set; }
    }
}
