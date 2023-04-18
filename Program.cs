const string CORRECT_PASSWORD = "123456";
const int PASSENGERS_QUANTITY = 5;

int passengerCurrentIndex = 0;
string[] passengerNames = new string[PASSENGERS_QUANTITY];
string[] passengerOrigins = new string[PASSENGERS_QUANTITY];
string[] passengerDestinations = new string[PASSENGERS_QUANTITY];
DateTime[] passengerFlightDate = new DateTime[PASSENGERS_QUANTITY];

string password;

int menuOption = 3;


// Login
do 
{
	introdution();
	
	Console.Write($"Escreva a senha: ");
	password = Console.ReadLine();
}
while (!login(password));

Console.Clear();

// Options
while(menuOption != 0) 
{
	Console.WriteLine($"Digite uma das opções abaixo");
	Console.WriteLine($"1 - Cadastrar passagem");
	Console.WriteLine($"2 - Listar Passagens");
	Console.WriteLine($"0 - Sair");
	Console.Write($"=> ");
	
	
	menuOption = int.Parse(Console.ReadLine());
		
	switch (menuOption) 
	{
		case 1:
			registerTicket();
			break;
		case 2:
			listTicket();
			break;
		case 0:
			break;
		default:
		 	invalidOption();
			break;
	}
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

static void invalidOption() 
{
	Console.Clear();
	Console.WriteLine($"Opção inválida");
	breakPoint();
}

void registerTicket() 
{
	Console.Clear();
	Console.WriteLine(@$"
---------------------------------------------
|            Cadastrar passagem             |
---------------------------------------------
	");
	
	Console.Write($"Digite o nome do passageiro: ");
	passengerNames[passengerCurrentIndex] = Console.ReadLine();
	
	Console.Write($"Digite a origem: ");
	passengerOrigins[passengerCurrentIndex] = Console.ReadLine();
	
	Console.Write($"Digite o destino: ");
	passengerDestinations[passengerCurrentIndex] = Console.ReadLine();
	
	Console.Write($"Digite a data da viagem: ");
	passengerFlightDate[passengerCurrentIndex] = DateTime.Parse(Console.ReadLine());
	
	Console.Clear();
	Console.WriteLine($"Passagem cadastrada com sucesso");
	passengerCurrentIndex++;
	breakPoint();
	
	Console.Write($"Deseja cadastrar mais uma passagem (S/N): ");
	char continueRegistration = char.Parse(Console.ReadLine().ToLower());
	
	if (continueRegistration == 's') 
	{
		registerTicket();
	}
	
	Console.Clear();
	
}

void listTicket() 
{
	Console.Clear();
	Console.WriteLine(@$"
---------------------------------------------
|            Lista de passagens             |
---------------------------------------------
	");
	
	for (int i = 0; i < passengerCurrentIndex; i++) 
	{
		Console.WriteLine($"Passagem #{i + 1}");
		Console.WriteLine($"Nome do passageiro: {passengerNames[i]}");
		Console.WriteLine($"Origem: {passengerOrigins[i]}");
		Console.WriteLine($"Destino: {passengerDestinations[i]}");
		Console.WriteLine($"Data: {passengerFlightDate[i].ToString("dd/MM/yyyy")}");
		Console.WriteLine($"");
	}
	
	breakPoint();
}