using AutoMapper;
using FirstStudioMusic.Application.Services.TransactionService.Dto;
using FirstStudioMusic.Database;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.TransactionService
{
    public class TransactionAppService : ITransactionAppService
    {
        private readonly StudioContext _context;
        private readonly IMapper _mapper;

        public TransactionAppService(StudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Transaction Create(CreateTransactionDto model)
        {
            var transaction = _mapper.Map<Transaction>(model);
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return transaction;
        }

        public Transaction Update(UpdateTransactionDto model)
        {
            var transaction = _mapper.Map<Transaction>(model);
            _context.Transactions.Update(transaction);
            _context.SaveChanges();

            return transaction;
        }
    }
}
