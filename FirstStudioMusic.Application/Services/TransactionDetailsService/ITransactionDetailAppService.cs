using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Services.TransactionDetailsService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionDetailsService
{
    public interface ITransactionDetailAppService
    {
        PagedResult<TransactionDetailDto> GetAllTransactionsDetail(PageInfo pageInfo);
    }
}
