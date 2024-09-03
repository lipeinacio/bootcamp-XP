using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Curso
{
    public string Nome { get; private set; }
    private List<string> alunos;

    public Curso(string nome)
    {
        Nome = nome;
        alunos = new List<string>();
    }

    public void AdicionarAluno(string aluno)
    {
        alunos.Add(aluno);
    }

    public void RemoverAluno(string aluno)
    {
        alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos no curso {Nome}:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}

}