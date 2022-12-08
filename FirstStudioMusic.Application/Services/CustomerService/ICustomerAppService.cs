using FirstStudioMusic.Application.Services.CustomerService.Dto;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.CustomerService
{
    public interface ICustomerAppService
    {
        Customer Create(CreateCustomerDto model);
        Customer Delete(int id);
        Customer Update(UpdateCustomerDto model);
    }
}
