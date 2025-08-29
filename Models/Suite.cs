namespace Sistema_de_Hospedagem.Models
{
    public class Suite
    {       
        public Suite(string tipoSuite, int capacidade, int valorDiaria) 
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string? TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

    }
}