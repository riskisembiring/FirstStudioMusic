using AutoMapper;
using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Services.StudioService.Dto;
using FirstStudioMusic.Database;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.StudioService
{
    public class StudioAppService : IStudioAppService
    {
        private readonly StudioContext _context;
        private readonly IMapper _mapper;

        public StudioAppService(StudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Studio Create(CreateStudioDto model)
        {
            var studio = _mapper.Map<Studio>(model);
            _context.Studios.Add(studio);
            _context.SaveChanges();

            return studio;
        }
        
        public Studio Delete(int id)
        {
            var studio = _context.Studios.FirstOrDefault(w => w.StudioId == id);
            _context.Studios.Remove(studio);
            _context.SaveChanges();

            return studio;
        }

        // Using LINQ type command
        public PagedResult<StudioListDto> GetAllStudio(PageInfo pageInfo)
        {
            var pagedResult = new PagedResult<StudioListDto>
            {
                Data = (from studio in _context.Studios
                        join customer in _context.Customers
                        on studio.StudioId equals customer.CustomerId
                        select new StudioListDto
                        {
                            NameRoom = studio.NameRoom,
                            TypeRoom = studio.TypeRoom,
                            CustomerName = customer.CustomerName
                        })  
                        .Skip(pageInfo.Skip) 
                        .Take(pageInfo.PageSize)
                        .OrderBy(w => w.NameRoom),
                        Total = _context.Studios.Count()
            };

            return pagedResult;
        }

        public Studio Update(UpdateStudioDto model)
        {
            var studio = _mapper.Map<Studio>(model);
            _context.Studios.Update(studio);
            _context.SaveChanges();

            return studio;
        }
    }
}
