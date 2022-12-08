using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Application.Services.StudioService.Dto
{
    public class UpdateStudioDto
    {
        public int IdStudio { get; set; }
        public string NameRoom { get; set; }
        public string TypeRoom { get; set; }

        public int CustomerId { get; set; }
    }
}
