using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Database.Models
{
    [Table("Transaction Detail")]
    public class TransactionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public int RentalLength { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
