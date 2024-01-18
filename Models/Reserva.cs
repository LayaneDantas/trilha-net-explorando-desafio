
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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
            //Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (Suite != null && Suite.Capacidade >= hospedes.Count)
           
            {
                Hospedes = hospedes;
            }
            else
            {

             // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
             throw new Exception("A capacidade da suíte não é suficiente para acomodar o número de hóspedes especificado.");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        { return Hospedes.Count; }

        // Retorna a quantidade de hóspedes (propriedade Hospedes)
       
        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor = DiasReservados * Suite.ValorDiaria * 0.9M;
            }

            return valor;
        }
    }
}
