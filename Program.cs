using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios OO");

            Aluno a1 = new Aluno ("Márcio", 46, 7.8);

            a1.Apresentar();

            Console.WriteLine();

            Professor p1 = new Professor("Teacher", 55, 8.500m);
            p1.Apresentar();

            
            
            //ContaCorrente c1 = new ContaCorrente(numero: 1, saldo: 100.00m);

            //Console.Write("Infome o valor de saque R$: ");
            //decimal saque = Convert.ToDecimal(Console.ReadLine());

            //c1.Sacar(saque);

            //c1.ExibirSaldo();
        }
    }
}
