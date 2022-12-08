using FirstStudioMusic.Application.Helpers;
using FirstStudioMusic.Application.Models;
using FirstStudioMusic.Application.Services.TransactionDetailsService;
using Microsoft.AspNetCore.Mvc;

namespace FirstStudioMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailsController : Controller
    {
        private ITransactionDetailAppService _transactionDetailAppService;
        public TransactionDetailsController(ITransactionDetailAppService transactionDetailAppService)
        {
            _transactionDetailAppService = transactionDetailAppService;
        }

        [HttpGet("GetAllTransactionDetails")]
        [Produces("application/json")]
        public IActionResult GetAllTransactionDetails([FromQuery] PageInfo pageInfo)
        {
            try
            {
                var details = _transactionDetailAppService.GetAllTransactionsDetail(pageInfo);
                return Requests.Response(this, new ApiStatus(200), details, "");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }
    }
}

