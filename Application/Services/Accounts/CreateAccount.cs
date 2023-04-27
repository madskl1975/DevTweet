using Domain.Models;

namespace Application.Services.Accounts
{
    public class CreateAccount
    {
        public bool Create(CreateAccountRequest request)
        {
            var account = new Account
            {
                Username = request.Username,
                Email = request.Email,
                Password = request.Password,
            };

            // Store account in DB.
            // account.Save();
            return true;
        }
    }
}
