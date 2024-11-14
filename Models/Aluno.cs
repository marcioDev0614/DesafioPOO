using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExemploPOO.Models
{
    class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno() { }

        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            Nota = nota;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nNota: {Nota}");
        }
    }
}
