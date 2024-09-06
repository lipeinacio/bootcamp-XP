using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models;

    // Herdando da Classe Pessoa
    public class Aluno : Pessoa
    {
        public Aluno(string nome): base(nome)
        {

        }
        public double Nota { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
    }
}
