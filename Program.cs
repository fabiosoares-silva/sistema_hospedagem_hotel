using Sistema_de_Hospedagem.Models;

List<Pessoa> hospedes = [];

Console.WriteLine("Bem-vindo(a) ao Sistema de Hospedagem!");
Thread.Sleep(3000);
Console.Clear();    

Console.WriteLine("Digite o nome do hospede principal: ");
string nomeHospede = Console.ReadLine()!;

Console.Clear();

Console.WriteLine("Digite o sobrenome do hospede principal: ");
string sobrenomeHospede = Console.ReadLine()!;

Console.Clear();

Console.WriteLine("Digite o tipo da suíte (Basic, Standard ou Luxo): ");
string tipoSuite = Console.ReadLine()!;

Console.Clear();

Console.WriteLine("Digite a quantas pessoas vão se hospedar: ");
int capacidade = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("Digite quantos dias ficará hospedado: ");
int diasReservados = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("Digite o valor da diária: ");
int valorDiaria = int.Parse(Console.ReadLine()!);

Console.Clear();

Pessoa novoHospede = new(nomeHospede, sobrenomeHospede);

hospedes.Add(novoHospede);

Suite suite = new(tipoSuite, capacidade, valorDiaria);

Reserva reserva = new(diasReservados, suite, hospedes);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Resumo Cadastral\n");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Suíte: {tipoSuite}");
Console.WriteLine($"Dias reservados: {diasReservados}");
Console.WriteLine($"Total de pessoas hospedadas: {capacidade}");
Console.WriteLine($"valor diária: {reserva.CalcularValorDiaria()}");

Console.WriteLine("\nPressione qualquer tecla para sair.");
Console.ReadKey();