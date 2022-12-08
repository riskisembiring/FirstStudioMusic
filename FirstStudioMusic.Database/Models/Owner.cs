using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Database.Models
{

    [Table("Owner")]
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OwnerId { get; set; }
        public string NameOwner { get; set; }
        public string PhoneNumber { get; set; } 

        public virtual IEnumerable<Transaction> Transactions { get; set; }
    }
}