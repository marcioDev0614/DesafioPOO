using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Desafio - Criando um Sistema e Abstraindo um Celular com POO");
            Console.WriteLine("****************************************************************");


            Console.WriteLine("Smartphone Nokia: ");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", iMEI: "111111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", iMEI: "2222222222", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
















































            //Aluno a1 = new Aluno ("Márcio", 46, 7.8);

            //a1.Apresentar();

            //Console.WriteLine();

            //Professor p1 = new Professor("Teacher", 55, 8.500m);
            //p1.Apresentar();



            //ContaCorrente c1 = new ContaCorrente(numero: 1, saldo: 100.00m);

            //Console.Write("Infome o valor de saque R$: ");
            //decimal saque = Convert.ToDecimal(Console.ReadLine());

            //c1.Sacar(saque);

            //c1.ExibirSaldo();
        }
    }
}
