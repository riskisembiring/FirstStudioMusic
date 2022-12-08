using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Services.StudioService.Dto;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.StudioService
{
    public interface IStudioAppService
    {
        Studio Create(CreateStudioDto model);
        Studio Update(UpdateStudioDto model);
        Studio Delete(int id);
        PagedResult<StudioListDto> GetAllStudio(PageInfo pageInfo);
    }
}
