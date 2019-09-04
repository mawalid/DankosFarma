using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dankos.Model
{
    [Table("trx_mastertransaksi")]
    public class MasterTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NoFaktur { get; set; }

        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required(AllowEmptyStrings = false)]
        public string NamaCustomer { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Total { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int CashReturn { get; set; }
    }
}