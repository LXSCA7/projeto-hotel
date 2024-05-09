using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("+------------------------------------------------------------------------------+");
Console.WriteLine("|                                  H O T E L                                   |");
Console.WriteLine("+-------------------------------------------------------------------------------");
Console.WriteLine("|                                   SUÍTES                                     |");
Console.WriteLine("+------------------------------------------------------------------------------+");
Console.WriteLine("| 1 - Suíte Padrão     | Capacidade: 1 hóspede    | Valor da diária: R$ 100,00 |");
Console.WriteLine("|                                                                              |");
Console.WriteLine("| 2 - Suíte Executiva  | Capacidade: 2 hóspedes   | Valor da diária: R$ 150,00 |");
Console.WriteLine("|                                                                              |");
Console.WriteLine("| 3 - Suíte Premium    | Capacidade: 2 hóspedes   | Valor da diária: R$ 250,00 |");
Console.WriteLine("|                                                                              |");
Console.WriteLine("| 4 - Suíte Master     | Capacidade: 2 hóspedes   | Valor da diária: R$ 300,00 |");
Console.WriteLine("|                                                                              |");
Console.WriteLine("| 5 - Suíte Familiar   | Capacidade: 4 hóspedes   | Valor da diária: R$ 500,00 |");
Console.WriteLine("|                                                                              |");
Console.WriteLine("| 6 - Master Superior  | Capacidade: 4 hóspedes   | Valor da diária: R$ 650,00 |");
Console.WriteLine("+------------------------------------------------------------------------------+\n");
Console.Write("Escolha a suíte: ");
string escolha = Console.ReadLine();

Suite suite;

switch (escolha)
{
    case "1":
        suite = new Suite(tipoSuite: "Padrão", capacidade: 1, valorDiaria: 100.00M);
        break;
    case "2":
        suite = new Suite(tipoSuite: "Executiva", capacidade: 2, valorDiaria: 150.00M);
        break;
    case "3":
        suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 250.00M);
        break;
    case "4":
        suite = new Suite(tipoSuite: "Master", capacidade: 2, valorDiaria: 300.00M);
        break;
    case "5":
        suite = new Suite(tipoSuite: "Familiar", capacidade: 4, valorDiaria: 500.00M);
        break;
    case "6":
        suite = new Suite(tipoSuite: "Superior", capacidade: 4, valorDiaria: 650.00M);
        break;
    default:
        throw new Exception("Erro. Suíte inexistente.");
        break;
}

Console.Write("Insira a quantidade de Hóspedes: ");
int quantidadeDeHospedes = Int32.Parse(Console.ReadLine());
Console.Clear();

for (int i = 0; i < quantidadeDeHospedes; i++)
{
    Console.Write("Insira nome do hóspede: ");
    string nomeHospede = Console.ReadLine();
    Console.Write("Insira Sobrenome do hóspede: ");
    string sobrenomeHospede = Console.ReadLine();
    hospedes.Add(new Pessoa(nomeHospede, sobrenomeHospede));
    Console.Clear();
}

Console.Write("Insira a quantidade de diárias: ");
int quantidadeDeDias = Int32.Parse(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: quantidadeDeDias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach (Pessoa i in hospedes)
{
    Console.WriteLine(" - " + i.NomeCompleto);
}
Console.WriteLine($"\nValor diária: {reserva.CalcularValorDiaria()}");