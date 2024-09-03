using ExemploPOO.Models;
using System;
using System.Globalization;


// Concatenando Strings
string nome = "João";
string saudacao = "Olá, " + nome + "!";
Console.WriteLine(saudacao);

// Interpolação de Strings
string interpolacao = $"Bem-vindo, {nome}!";
Console.WriteLine(interpolacao);

// Ajustando a numeração
int numero = 123;
string numeroFormatado = numero.ToString("D6"); // Preenche com zeros à esquerda
Console.WriteLine($"Número ajustado: {numeroFormatado}");

// Concatenação de valores
double preco = 19.99;
string mensagemPreco = "O preço do item é " + preco.ToString("F2") + " reais.";
Console.WriteLine(mensagemPreco);

// Formatando valores monetários
CultureInfo culturaBrasil = new CultureInfo("pt-BR");
string precoMonetario = preco.ToString("C2", culturaBrasil);
Console.WriteLine($"Preço formatado: {precoMonetario}");

// Alterando a localização da cultura
CultureInfo culturaEUA = new CultureInfo("en-US");
string precoEUA = preco.ToString("C2", culturaEUA);
Console.WriteLine($"Preço formatado (EUA): {precoEUA}");

// Formatação personalizada
double percentual = 0.258;
string percentualFormatado = percentual.ToString("P2"); // Formata como porcentagem
Console.WriteLine($"Porcentagem formatada: {percentualFormatado}");

// Formatando o tipo DateTime
DateTime dataAtual = DateTime.Now;
string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine($"Data formatada: {dataFormatada}");

// Formatando data e hora
string dataHoraFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");
Console.WriteLine($"Data e hora formatadas: {dataHoraFormatada}");

// Datetime com TryParse
string dataTexto = "03/09/2024";
if (DateTime.TryParseExact(dataTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida))
{
    Console.WriteLine($"Data convertida com sucesso: {dataConvertida.ToString("dd/MM/yyyy")}");
}
else
{
    Console.WriteLine("Formato de data inválido.");
}




// Curso curso = new Curso("Desenvolvimento de Software");
//         curso.AdicionarAluno("Alice");
//         curso.AdicionarAluno("Bob");
//         curso.AdicionarAluno("Carlos");
//         curso.ListarAlunos();
//         curso.RemoverAluno("Bob");
//         curso.ListarAlunos();






// ContaCorrente c1 = new ContaCorrente(123,1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();









// Pessoa p1 = new Pessoa();

// p1.Nome = "Felipe";
// p1.Idade = 20;

// p1.Apresentar();