using FirstStudioMusic.Application.Services.OwnerService.Dto;
using FirstStudioMusic.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.OwnerService
{
    public interface IOwnerAppService
    {
        Owner Create(CreateOwnerDto model);
        Owner Update(UpdateOwnerDto model);
    }
}
