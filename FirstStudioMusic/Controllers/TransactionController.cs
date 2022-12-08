using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Models;
using FirstStudioMusic.Application.Services.TransactionService.Dto;
using FirstStudioMusic.Application.Services.TransactionService;
using Microsoft.AspNetCore.Mvc;

namespace FirstStudioMusic.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly ITransactionAppService _transactionAppService;
        public TransactionController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        [HttpPost("CreateTransaction")]
        public IActionResult Create([FromBody] CreateTransactionDto model)
        {
            try
            {
                var trans = _transactionAppService.Create(model);
                if (trans == null)
                {
                    return Requests.Response(this, new ApiStatus(406), trans, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), trans, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }


        [HttpPatch("UpdateTransaction")]
        public IActionResult Update([FromBody] UpdateTransactionDto model)
        {
            try
            {
                var trans = _transactionAppService.Update(model);
                if (trans == null)
                {
                    return Requests.Response(this, new ApiStatus(406), trans, "error");
                }
                return Requests.Response(this, new ApiStatus(200), trans, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
