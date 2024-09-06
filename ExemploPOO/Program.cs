using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System;
using System.Globalization;

ICalculadora cal = new Calculadora();
Console.WriteLine(cal.Multiplicar(3,3));


Corrente c = new Corrente();


Aluno a1 = new("Paulo")
{
    Idade = 21,
    Nota = 10
};
a1.Apresentar();

Professor p1 = new Professor("Joao");

p1.Idade = 31;
p1.Salario = 1000;
p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(123,1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

c.Creditar(200);
c.ExibirSaldo();






// Pessoa p1 = new Pessoa();

// p1.Nome = "Felipe";
// p1.Idade = 20;

// p1.Apresentar();