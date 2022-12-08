using FirstStudioMusic.Application.Services.TransactionService.Dto;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionService
{
    public interface ITransactionAppService
    {
        Transaction Create(CreateTransactionDto model);
        Transaction Update(UpdateTransactionDto model);
    }
}
