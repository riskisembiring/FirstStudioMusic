using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionService.Dto
{
    public class CreateTransactionDto
    {
        public int CustomerId { get; set; }
        public int OwnerId { get; set; }
        public int RentalLength { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> Date { get; set; }
    }
}
