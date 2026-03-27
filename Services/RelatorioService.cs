using Sistema_de_Hospedagem.Models;

namespace Sistema_de_Hospedagem.Services;

static class RelatorioService
{
    public static void ExibirResumoDaHospedagem(Pessoa pessoa, Reserva reserva, Suite tipoSuite)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("            RESUMO DA HOSPEDAGEM              ");
        Console.WriteLine("==============================================");        
        Console.WriteLine($"Hóspedes cadastrados: {pessoa.NomeCompleto}");
        Console.WriteLine($"Suíte:                {tipoSuite.TipoSuite}");
        Console.WriteLine($"Período:              {reserva.DiasReservados}");        
        Console.WriteLine($"Valor total:          {reserva.CalcularValorDiaria():C}");
        Console.WriteLine("==============================================");
    }
}
