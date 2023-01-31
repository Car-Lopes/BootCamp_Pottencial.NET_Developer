// See https://aka.ms/new-console-template for more information
// Para comentar varias linhas ao mesmo tempo CTRL + K, CTRL + C
// Para remover comentarios de varias linhas ao mesmo tempo CTRL + K, CTRL + U
using ExemploExplorando.Models;
using System.Globalization;

//declarando um dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();

//Adicionando elementos
estados.Add("SP","São Paulo");
estados.Add("RJ","Rio de Janeiro");
estados.Add("MG", "Minas Gerais");


foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("--------------");
Console.WriteLine($"Removendo o estodo do RJ " + estados.Remove("RJ"));

//Removendo 
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("--------------");
//Alterando valor 
Console.WriteLine($"Alterando o estodo de SP ");
estados["SP"] = "São Paulo - Capital";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("--------------");

//Verificando se existe a chave
string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor ja exite: {chave}");
}
else 
{
    Console.WriteLine($"Valor não existe, Pode se adicionado: {chave}");
}

Console.WriteLine("--------------");

Console.WriteLine("Obtendo o valor");

Console.WriteLine(estados["MG"]);









// //Pilha no C#
// Stack<int> pilha = new Stack<int>();

// //adicionando elementos na pinha
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// //Removendo elemento da pilha 
// Console.WriteLine("Removendo elemento " + pilha.Pop());
// Console.WriteLine($"Removendo Elemento {pilha.Pop()}");

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }












// //Filas no C#
// Queue<int> fila = new Queue<int>();

// Console.WriteLine("Adicionando na fila");
// fila.Enqueue(2); //1°
// fila.Enqueue(4); //2°
// fila.Enqueue(6); //3°

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// //Removendo da fila
// //Sempre remove o 1° da fila 
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }










//new ExemploExcecao().Metodo1();






// // Tratando a Exceção
// try 
// {

//     //Para ler o arquivo 
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//                         //ler todas as linha   //caminho do arquivo

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }                      

// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine("Erro na leitura do arquivo. " 
//                        + "Arquivo não encontrado " + ex.Message);
// } 
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica.{ex.Message}");
// }
// finally 
// {
//     Console.WriteLine("Chegou até aqui caiu no finally");
// }





















// DateTime date  = DateTime.Now;

// Console.WriteLine(date.ToString("dd/MM/yy HH:mm"));



// DateTime date2  = DateTime.Parse("17/04/2022 18:00");

// Console.WriteLine(date2);



// //TryParse

// string dataString = "2022-13-20 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
//                    CultureInfo.InvariantCulture, 
//                    DateTimeStyles.None, 
//                    out DateTime data3);

// // Validando a data 
// if (sucesso)
// {
//     Console.WriteLine($"Conversão C/Sucesso {data3}");
// }
// else 
// {
//      Console.WriteLine($"{dataString} não é data valida {data3}");
// }


// Console.WriteLine(data3);








//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//Formantando Valores Monetarios 
// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2"));








// int numero1 = 10;
// string numero2 = "20";
 

// string resul = numero1 + numero2;

// Console.WriteLine(resul);












// Pessoa p1 = new Pessoa(nome:"Carlos", sobrenome:"Lopes"); //Chamando Metodo Construtor 
// Pessoa p2 = new Pessoa(nome:"Leticia", sobrenome:"Andradde");
// Pessoa p3 = new Pessoa(nome:"Bernardo", sobrenome:"Andrade");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();



/*
Pessoa p1 = new Pessoa();
p1.Nome = "Carlos"; //Sinal de igual chamando o SET
p1.Sobrenome = "Lopes";
p1.Idade = 31;

p1.Apresentar();
*/

