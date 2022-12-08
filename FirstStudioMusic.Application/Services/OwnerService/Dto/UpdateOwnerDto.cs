using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.OwnerService.Dto
{
    public class UpdateOwnerDto
    {
        public int OwnerId { get; set; }
        public string NameOwner { get; set; }
        public string PhoneNumber { get; set; }

    }
}
