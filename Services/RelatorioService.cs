using Sistema_de_Hospedagem.Models;

namespace Sistema_de_Hospedagem.Services;

static class RelatorioService
{
    public static void ExibirResumoDaHospedagem(Pessoa nomeHospede, Reserva reserva, string tipoSuite)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("            RESUMO DA HOSPEDAGEM              ");
        Console.WriteLine("==============================================");        
        Console.WriteLine($"Hóspedes cadastrados: {nomeHospede.Nome} {nomeHospede.Sobrenome}");
        Console.WriteLine($"Suíte:                {tipoSuite}");
        Console.WriteLine($"Período:              {reserva.DiasReservados}");        
        Console.WriteLine($"Valor total:          {reserva.CalcularValorDiaria()}");
        Console.WriteLine("==============================================");
    }
}
