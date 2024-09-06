using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models;

    public class Pessoa // Classe definida por Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; } = "Sem Nome"; // Abstracao Realizada para adiquirir
        public int Idade { get; set; }   // Informações|Variaveis

        public virtual void Apresentar() // Metodo
        {
            Console.WriteLine($"Olá meu nome é {Nome}" +
            $" e tenho {Idade} anos");
        }
    }
