using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Database.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int OwnerId { get; set; }
        public int RentalLength { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> Date { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual IEnumerable<TransactionDetail> TransactionDetails { get; set; }
    }
}