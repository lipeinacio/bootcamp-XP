using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models;

    public class Pessoa // Classe definida por Pessoa
    {
        public string Nome { get; set; } = "Sem Nome"; // Abstracao Realizada para adiquirir
        public int Idade { get; set; }   // Informações|Variaveis

        public void Apresentar() // Metodo
        {
            Console.WriteLine($"Olá meu nome é {Nome}" +
            $" e tenho {Idade} anos");
        }
    }
