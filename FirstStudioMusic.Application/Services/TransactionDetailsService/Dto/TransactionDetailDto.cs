using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionDetailsService.Dto
{
    public class TransactionDetailDto
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> Date { get; set; }
    }
}
