using System.Diagnostics;
using System.Runtime.InteropServices;
using Fundamentos.Models;





// // Introdução a Exceções
// try
// {
//     // Realizando a leitura de um arquivo
//     string caminhoArquivo = "arquivo.txt";
//     string conteudo = File.ReadAllText(caminhoArquivo);
//     Console.WriteLine("Conteúdo do arquivo:");
//     Console.WriteLine(conteudo);
// }
// catch (FileNotFoundException ex)
// {
//     // Disparando uma exceção
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// catch (Exception ex)
// {
//     // Tratando uma exceção
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// }
// finally
// {
//     // Entendendo o bloco finally
//     Console.WriteLine("Operação de leitura de arquivo concluída.");
// }

// // Usando o throw
// try
// {
//     VerificarNumero(10);
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine($"Exceção específica: {ex.Message}");
// }

// // Introdução a Filas
// Queue<string> fila = new Queue<string>();
// fila.Enqueue("Primeiro");
// fila.Enqueue("Segundo");
// fila.Enqueue("Terceiro");

// Console.WriteLine("Elementos da fila:");
// while (fila.Count > 0)
// {
//     Console.WriteLine(fila.Dequeue());
// }

// // Introdução a Pilhas
// Stack<string> pilha = new Stack<string>();
// pilha.Push("Primeiro");
// pilha.Push("Segundo");
// pilha.Push("Terceiro");

// Console.WriteLine("Elementos da pilha:");
// while (pilha.Count > 0)
// {
//     Console.WriteLine(pilha.Pop());
// }

// // Introdução ao Dictionary
// Dictionary<string, int> dicionario = new Dictionary<string, int>();
// dicionario["Um"] = 1;
// dicionario["Dois"] = 2;
// dicionario["Três"] = 3;

// // Removendo e alterando elementos
// dicionario["Dois"] = 22;
// dicionario.Remove("Um");

// Console.WriteLine("Elementos do dicionário:");
// foreach (var item in dicionario)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }


// // Método para usar o throw
// static void VerificarNumero(int numero)
// {
//     if (numero < 0)
//     {
//         throw new ArgumentOutOfRangeException("O número não pode ser negativo.");
//     }
//     Console.WriteLine("Número válido.");
// }



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














// List<string> listaString = [];

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");

// for(int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posicao {i} - {listaString[i]}");
// }
// int x = 0;

// foreach(string str in listaString)
// {
//     Console.WriteLine($"Posicao N°{x} - {listaString[x]}");
//     x++;
// }




// int[] arrayInteiros = [72, 69, 50]; 
// // [] -> Um array armazena valores dentro de uma só variável.

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// // Array.Resize da um novo tamanho a um array.

// int[] arrayInteiros2 = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteiros2, arrayInteiros.Length);
// // Copia um Array e pode mudar seu tamanho


// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }











// Pessoa p = new()
// {
//     Nome = "Felipe",
//     Idade = 21,

// };

//     p.Apresentar();


// string opcao;

// while(true) // Exemplo menu interativo
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção Invalida!");
//             break;
//     }
// }




// int soma = 0,numero = 0;


// do // Funciona enquanto a condicao nao e satisfeita
// {

//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;



// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");



// int numero = 10;
// int contador = 0;
// int auxiliar = 0;

// while (contador <= 10) // Enquanto for true/false, ele roda
// {
//         Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//         contador++;

//         if (contador == 6)
//         {
//             break;
//         }
// }



// int numero = 10; // Roda o tanto de vezes determinadas


// for(int contador = 0; contador <= 10; contador ++)

// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }











// Calculadora calc = new();

// calc.Somar(10,30);
// calc.Subtrair(10,30);
// calc.Multiplicar(10,30);
// calc.Dividir(10,30);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(2);

// int numero = 10;

// Console.WriteLine("Incremento o 10");
// // numero = numero + 1;
// numero ++;

// Console.WriteLine(numero);










//         // Operador NOT (!) -- Inversão de Operadores

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }





//         // Operador Logico AND (&&) -- TUDO TRUE

// bool possuiPresenca = true;
// double media = 7.5;

// if (possuiPresenca && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }




//         // Operador Logico OR (||) -- PELO MENOS UM TRUE
// bool maiorDeIdade = false;
// bool possuiAutorizacao = false;

// if (maiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada Negada");
// }










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