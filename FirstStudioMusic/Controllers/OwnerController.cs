using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Models;
using FirstStudioMusic.Application.Services.CustomerService;
using FirstStudioMusic.Application.Services.CustomerService.Dto;
using FirstStudioMusic.Application.Services.OwnerService;
using FirstStudioMusic.Application.Services.OwnerService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FirstStudioMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {

        private readonly IOwnerAppService _ownerAppService;

        public OwnerController(IOwnerAppService ownerAppService)
        {
            _ownerAppService = ownerAppService;
        }

        [HttpPost("CreateOwner")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] CreateOwnerDto model)
        {
            try
            {
                var owner = _ownerAppService.Create(model);
                return Requests.Response(this, new ApiStatus(200), owner, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpPatch("UpdateOwner")]
        public IActionResult Update([FromBody] UpdateOwnerDto model)
        {
            try
            {
                var owner = _ownerAppService.Update(model);
                if (owner == null)
                {
                    return Requests.Response(this, new ApiStatus(406), owner, "error");
                }
                return Requests.Response(this, new ApiStatus(200), owner, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }
    }
}
