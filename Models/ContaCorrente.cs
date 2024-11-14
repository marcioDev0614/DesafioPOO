using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    class ContaCorrente
    {
        public int Numero { get; set; }
        private decimal Saldo { get; set; }

        public ContaCorrente()
        {
        }
        public ContaCorrente(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }

        public void Sacar(Decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo} reais");
        }
    }
}
