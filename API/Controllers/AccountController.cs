using Application.Services.Accounts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public string CreateAccount(CreateAccountRequest request)
        {
            var createAccount = new CreateAccount();
            var isSuccess = createAccount.Create(request);
            
            return isSuccess ? "Tillykke!!" : "Bad luck...";
        }
    }
}
