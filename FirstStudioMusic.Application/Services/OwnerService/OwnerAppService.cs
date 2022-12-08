using AutoMapper;
using FirstStudioMusic.Application.Services.OwnerService.Dto;
using FirstStudioMusic.Database;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.OwnerService
{
    public class OwnerAppService : IOwnerAppService
    {

        private readonly StudioContext _context;
        private readonly IMapper _mapper;
        public OwnerAppService(StudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Owner Create(CreateOwnerDto model)
        {
            var owner = _mapper.Map<Owner>(model);
            _context.FieldOwners.Add(owner);
            _context.SaveChanges();

            return owner;
        }

        public Owner Update(UpdateOwnerDto model)
        {
            var owner = _mapper.Map<Owner>(model);
            _context.FieldOwners.Update(owner);
            _context.SaveChanges();

            return owner;
        }
    }
}
