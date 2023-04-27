using Application.Services.Accounts;

// Vi har vores FRONTEND

// FRONTEND HAR NOGLE FELTER MED username, email og password SOM BRUGEREN KAN UDFYLDE

// FRONTEND SAMLER DATA FRA BRUGEREN

// FRONTEND KALDER API KALD OG SENDER username, email og password TIL BACKEND

// POST REQUEST: https://myapi.example.com/accounts 

// .... -v- ............

var createAccount = new CreateAccount();
var userRequestFromFrontend = new CreateAccountRequest
{
    Username = "shemsiu",
    Email = "vigan@shemsiu.dk",
    Password = "hejhej123"
};

var isSuccess = createAccount.Create(userRequestFromFrontend);

if (isSuccess)
{
    Console.WriteLine("Du er nu oprettet.");
} else
{
    Console.WriteLine("Der var fejl i dine indtastninger");
}

