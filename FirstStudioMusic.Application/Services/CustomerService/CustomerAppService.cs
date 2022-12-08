using AutoMapper;
using FirstStudioMusic.Application.Services.CustomerService.Dto;
using FirstStudioMusic.Database;
using FirstStudioMusic.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.CustomerService
{
    public class CustomerAppService : ICustomerAppService
    {    
		private readonly StudioContext _context;
		private readonly IMapper _mapper;

		public CustomerAppService(StudioContext context, IMapper mapper)
		{
			_context= context;
			_mapper= mapper;
		}
        public Customer Create(CreateCustomerDto model)
        {
            var customer = _mapper.Map<Customer>(model);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        public Customer Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(w => w.CustomerId == id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return customer;
        }

            public Customer Update(UpdateCustomerDto model)
        {
            var customer = _mapper.Map<Customer>(model);
            _context.Customers.Update(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}
