using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public Professor()
        {
        }
        public Professor(string nome, int idade, decimal salario) :base(nome, idade)
        {
            Salario = salario;
        }


        public override void Apresentar()
        {
            Console.WriteLine($"Nome {Nome}\nIdade: {Idade}\nSalário: {Salario}");
        }
    }
}
