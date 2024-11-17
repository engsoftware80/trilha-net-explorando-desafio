namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (Suite == null)
            {
                throw new Exception("Nenhuma suíte foi cadastrada. Cadastre uma suíte antes de adicionar hóspedes.");
            }

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
             // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            
            return Hospedes != null ? Hospedes.Count : 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            
            if (Suite == null)
            {
                throw new Exception("Nenhuma suíte foi cadastrada.");
            }
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
           
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m; 
            }

            return valor;
        }
    }
}