using ExemploPOO.Models;
using System;
using System.Globalization;

// Introdução a Exceções
try
{
    // Realizando a leitura de um arquivo
    string caminhoArquivo = "arquivo.txt";
    string conteudo = File.ReadAllText(caminhoArquivo);
    Console.WriteLine("Conteúdo do arquivo:");
    Console.WriteLine(conteudo);
}
catch (FileNotFoundException ex)
{
    // Disparando uma exceção
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    // Tratando uma exceção
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    // Entendendo o bloco finally
    Console.WriteLine("Operação de leitura de arquivo concluída.");
}

// Usando o throw
try
{
    VerificarNumero(10);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Exceção específica: {ex.Message}");
}

// Introdução a Filas
Queue<string> fila = new Queue<string>();
fila.Enqueue("Primeiro");
fila.Enqueue("Segundo");
fila.Enqueue("Terceiro");

Console.WriteLine("Elementos da fila:");
while (fila.Count > 0)
{
    Console.WriteLine(fila.Dequeue());
}

// Introdução a Pilhas
Stack<string> pilha = new Stack<string>();
pilha.Push("Primeiro");
pilha.Push("Segundo");
pilha.Push("Terceiro");

Console.WriteLine("Elementos da pilha:");
while (pilha.Count > 0)
{
    Console.WriteLine(pilha.Pop());
}

// Introdução ao Dictionary
Dictionary<string, int> dicionario = new Dictionary<string, int>();
dicionario["Um"] = 1;
dicionario["Dois"] = 2;
dicionario["Três"] = 3;

// Removendo e alterando elementos
dicionario["Dois"] = 22;
dicionario.Remove("Um");

Console.WriteLine("Elementos do dicionário:");
foreach (var item in dicionario)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}


// Método para usar o throw
static void VerificarNumero(int numero)
{
    if (numero < 0)
    {
        throw new ArgumentOutOfRangeException("O número não pode ser negativo.");
    }
    Console.WriteLine("Número válido.");
}



// // Concatenando Strings
// string nome = "João";
// string saudacao = "Olá, " + nome + "!";
// Console.WriteLine(saudacao);

// // Interpolação de Strings
// string interpolacao = $"Bem-vindo, {nome}!";
// Console.WriteLine(interpolacao);

// // Ajustando a numeração
// int numero = 123;
// string numeroFormatado = numero.ToString("D6"); // Preenche com zeros à esquerda
// Console.WriteLine($"Número ajustado: {numeroFormatado}");

// // Concatenação de valores
// double preco = 19.99;
// string mensagemPreco = "O preço do item é " + preco.ToString("F2") + " reais.";
// Console.WriteLine(mensagemPreco);

// // Formatando valores monetários
// CultureInfo culturaBrasil = new CultureInfo("pt-BR");
// string precoMonetario = preco.ToString("C2", culturaBrasil);
// Console.WriteLine($"Preço formatado: {precoMonetario}");

// // Alterando a localização da cultura
// CultureInfo culturaEUA = new CultureInfo("en-US");
// string precoEUA = preco.ToString("C2", culturaEUA);
// Console.WriteLine($"Preço formatado (EUA): {precoEUA}");

// // Formatação personalizada
// double percentual = 0.258;
// string percentualFormatado = percentual.ToString("P2"); // Formata como porcentagem
// Console.WriteLine($"Porcentagem formatada: {percentualFormatado}");

// // Formatando o tipo DateTime
// DateTime dataAtual = DateTime.Now;
// string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
// Console.WriteLine($"Data formatada: {dataFormatada}");

// // Formatando data e hora
// string dataHoraFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");
// Console.WriteLine($"Data e hora formatadas: {dataHoraFormatada}");

// // Datetime com TryParse
// string dataTexto = "03/09/2024";
// if (DateTime.TryParseExact(dataTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida))
// {
//     Console.WriteLine($"Data convertida com sucesso: {dataConvertida.ToString("dd/MM/yyyy")}");
// }
// else
// {
//     Console.WriteLine("Formato de data inválido.");
// }




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