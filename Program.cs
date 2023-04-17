const string CORRECT_PASSWORD = "123456";
const int PASSENGERS_QUANTITY = 5;

int passengerCurrentIndex = 0;
string[] passengerNames = new string[PASSENGERS_QUANTITY];
string[] passengerOrigins = new string[PASSENGERS_QUANTITY];
string[] passengerDestinations = new string[PASSENGERS_QUANTITY];
DateTime[] passengerFlightDate = new DateTime[PASSENGERS_QUANTITY];

string password;

int menuOption = 0;


// Login
do 
{
	introdution();
	
	Console.Write($"Escreva a senha: ");
	password = Console.ReadLine();
}
while (!login(password));

// Options

switch (menuOption) 
{
	case 1:
		break;
	case 2:
		break;
	case 0:
		break;
	
}


static void introdution() 
{
	Console.WriteLine(@$"
	---------------------------------------------
	|                                           |
	|               MACEDO AIRLINES             |
	|                                           |
	---------------------------------------------
	");
}

static bool login(string password) 
{
	if (password == CORRECT_PASSWORD) 
	{
		return true;
	} 
	else 
	{
		Console.WriteLine($"Senha incorreta! digite novamente.");
		breakPoint();
		
		return false;
	}
}

static void breakPoint() 
{
	Console.WriteLine($"Precione qualquer botão para continuar...");
	Console.ReadKey();
	Console.Clear();
}