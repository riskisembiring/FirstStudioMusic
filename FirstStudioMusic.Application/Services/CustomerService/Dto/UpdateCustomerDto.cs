﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.CustomerService.Dto
{
    public class UpdateCustomerDto
    {
        public int IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
