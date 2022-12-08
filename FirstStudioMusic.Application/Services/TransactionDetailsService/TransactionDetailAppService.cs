using AutoMapper;
using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Services.TransactionDetailsService;
using FirstStudioMusic.Application.Services.TransactionDetailsService.Dto;
using FirstStudioMusic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionDetails
{
    public class TransactionDetailAppService : ITransactionDetailAppService
    {
        private readonly StudioContext _context;
        private readonly IMapper _mapper;

        public TransactionDetailAppService(StudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Using LINQ type command
        public PagedResult<TransactionDetailDto> GetAllTransactionsDetail(PageInfo pageInfo)
        {
            var pagedResult = new PagedResult<TransactionDetailDto>
            {
                Data = (from transaction in _context.Transactions
                        select new TransactionDetailDto
                        {
                            TransactionId = transaction.TransactionId,
                            CustomerId = transaction.CustomerId,
                            Price = transaction.Price,
                            Status = transaction.Status,
                            Date = transaction.Date

                        })
                        .Skip(pageInfo.Skip)
                        .Take(pageInfo.PageSize)
                        .OrderBy(w => w.Date),
                Total = _context.TransactionDetails.Count()
            };

            return pagedResult;
        }
    }
}
