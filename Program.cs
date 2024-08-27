using System.Diagnostics;
using dotnet.Models;



        // Operador NOT (!) -- Inversão de Operadores

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}





        // Operador Logico AND (&&) -- TUDO TRUE

bool possuiPresenca = true;
double media = 7.5;

if (possuiPresenca && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}




        // Operador Logico OR (||) -- PELO MENOS UM TRUE
bool maiorDeIdade = false;
bool possuiAutorizacao = false;

if (maiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Entrada Liberada");
}
else
{
    Console.WriteLine("Entrada Negada");
}










// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma Vogal");
//         break;
    
//     default:
//         Console.WriteLine("Não é uma Vogal");
//         break;
// }







// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if ( 
//     letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"
//     ) 
// {
//     Console.WriteLine("É uma Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é Uma Vogal");
// }









// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

//     Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
//     Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
//     Console.WriteLine($"É possívek realizar a venda? {possivelVenda}");

// if (possivelVenda) 
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade em estoque.");
// }



//     int a = int.Parse ("5");
//     Console.WriteLine(a);

// // Cast - Casting

//     int a = Convert.ToInt32 ("5");
//     Console.WriteLine(a);




// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa p = new()
// {
//     Nome = "Felipe",
//     Idade = 21,
// };

//     p.Apresentar();