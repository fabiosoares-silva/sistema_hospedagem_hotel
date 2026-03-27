namespace Sistema_de_Hospedagem.Models
{
    public class Reserva(int diasReservados)
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; } = diasReservados;

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new System.ArgumentException("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {       
           Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {            
            return Hospedes!.Count;
        }
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite!.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m;
            }

            return valor;
        }
    }
}