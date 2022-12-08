using AutoMapper;
using FirstStudioMusic.Application.Services.CustomerService.Dto;
using FirstStudioMusic.Application.Services.OwnerService.Dto;
using FirstStudioMusic.Application.Services.StudioService.Dto;
using FirstStudioMusic.Application.Services.TransactionDetailsService.Dto;
using FirstStudioMusic.Application.Services.TransactionService.Dto;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            // Customer
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<Customer, CreateCustomerDto>();

            CreateMap<Customer, UpdateCustomerDto>();
            CreateMap<UpdateCustomerDto, Customer>();

            
            // Owner
            CreateMap<CreateOwnerDto, Owner>();
            CreateMap<Owner, CreateOwnerDto>();

            CreateMap<Owner, UpdateOwnerDto>();
            CreateMap<UpdateOwnerDto, Owner>();


            // Studio
            CreateMap<CreateStudioDto, Studio>();
            CreateMap<Studio, CreateStudioDto>();

            CreateMap<StudioListDto, Studio>();
            CreateMap<Studio, StudioListDto>();

            CreateMap<Studio, UpdateStudioDto>();
            CreateMap<UpdateStudioDto, Studio>();


            // Transaction
            CreateMap<Transaction, CreateTransactionDto>();
            CreateMap<CreateTransactionDto, Transaction>();

            CreateMap<Transaction, UpdateTransactionDto>();
            CreateMap<UpdateTransactionDto, Transaction>();


            // Transaction Detail
            CreateMap<TransactionDetail, TransactionDetailDto>();
            CreateMap<TransactionDetailDto, TransactionDetail>();

        }
    }
}
