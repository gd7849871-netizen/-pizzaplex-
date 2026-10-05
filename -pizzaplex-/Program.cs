using _pizzaplex_.Dominio;

CadastroCliente cliente = new CadastroCliente();
cliente.Cadastrar();

int numero1 = 10;
int numero2 = 20;
int numero3 = 30;
string nome = "Teste";

List<int> numeros = new List<int>();
numeros.Add(numero2);
Console.WriteLine(numeros);
foreach (int item in numeros)
{
    Console.WriteLine(item);
}