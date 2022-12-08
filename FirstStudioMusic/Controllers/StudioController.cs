using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Models;
using FirstStudioMusic.Application.Services.OwnerService;
using FirstStudioMusic.Application.Services.StudioService;
using FirstStudioMusic.Application.Services.StudioService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FirstStudioMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : Controller
    {

        private readonly IStudioAppService _studioAppService;

        public StudioController(IStudioAppService studioAppService)
        {
            _studioAppService = studioAppService;
        }

        [HttpGet("GetAllStudio")]
        [Produces("application/json")]
        public IActionResult GetAllStudio([FromQuery] PageInfo pageInfo)
        {
            try
            {
                var studioList = _studioAppService.GetAllStudio(pageInfo);
                return Requests.Response(this, new ApiStatus(200), studioList, "");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpPost("CreateStudio")]
        public IActionResult Create([FromBody] CreateStudioDto model)
        {
            try
            {
                var studio = _studioAppService.Create(model);
                if (studio == null)
                {
                    return Requests.Response(this, new ApiStatus(406), studio, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), studio, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpPatch("UpdateStudio")]
        public IActionResult Edit([FromBody] UpdateStudioDto model)
        {
            try
            {
                var field = _studioAppService.Update(model);
                if (field == null)
                {
                    return Requests.Response(this, new ApiStatus(406), field, "error");
                }
                return Requests.Response(this, new ApiStatus(200), field, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpDelete("DeleteStudio")]
        public IActionResult Delete(int id)
        {
            try
            {
                var field = _studioAppService.Delete(id);
                if (field == null)
                {
                    return Requests.Response(this, new ApiStatus(406), field, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), field, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
