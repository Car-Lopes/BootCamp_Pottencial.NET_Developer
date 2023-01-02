using System;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Podemos instanciar a classe dessa forma 
//Projeto_CSharp.Moldes.Pessoa p = new Projeto_CSharp.Moldes.Pessoa();

// ou usando o Using que é o Caminho do namespace aonde essa classe esta
using ExemploFundamentos.Common.Moldes;

//Criando a instancia da classe pessoa 
Pessoa p = new Pessoa();

//Atribuindo os atributos da classe pessoa e chamando o metodo
p.Nome = "Carlos";
p.Idade = 31;
p.Apresentar(); 


//Para comentar varias linhas de uma só vez é só 
//selecionar as linhas segura o CTRL + K + C


// Variaveis
string apresentacao = " String";
int quantidade =1;
//Manipulação de variaveis
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine("Valor da Variavel apresentacao do tipo" + apresentacao);
Console.WriteLine("Valor da Variavel quantidade do tipo int: " + quantidade);
Console.WriteLine("Valor da Variavel altura do tipo double: " + altura.ToString("0.00"));
Console.WriteLine("Valor da Variavel preco do tipo decimal: " + preco);
Console.WriteLine("Valor da Variavel condicao do tipo bool: " + condicao);


//Variavel do tipo DateTime
DateTime dataAtual = DateTime.Now;
Console.WriteLine("Valor da Variavel do Tipo Data " + dataAtual);


//Adicionando dias 
DateTime dataAtual1 = DateTime.Now.AddDays(5);
Console.WriteLine("Adcionando dias na data  " + dataAtual1);


//imprimindo só a data 
DateTime dataAtual2 = DateTime.Now.AddDays(5);
Console.WriteLine("Imprimindo só a data   " + dataAtual2.ToString("dd/MM/yyyy"));


// Combinando Operadores
int a = 10;
int b = 20;

int c = a + b;

c = c + 5;
Console.WriteLine(c);



string f = "15b";
int e = 2; 
int.TryParse(f, out e);
Console.WriteLine(e);
Console.WriteLine("Conversao realizada com sucesso!");


int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; 

Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de Compra: {quantidadeCompra}");
Console.WriteLine($"É Possivel a compra: {possivelVenda}");

if (quantidadeCompra == 0){//==Comparação
    Console.WriteLine("Venda Invalida!.");
} else if (possivelVenda){
    Console.WriteLine("Venda Realizada.");
} else {
    Console.WriteLine("Desculpe. Não temos a Quantidade desejada em estoque");
}



// Exemplo Switch case e IF e Else 
Console.WriteLine("Digite Uma letra");
string? letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default: 
        Console.WriteLine("Não é vogal");
        break;    
}


// Operador || (ou)
Console.WriteLine("Digite Uma letra");
string? letra1 = Console.ReadLine();

if (letra1 == "a" ||
    letra1 == "e" ||
    letra1 == "i" ||
    letra1 == "o" ||
    letra1 == "u" ){
        Console.WriteLine("Vogal");
    } else {
        Console.WriteLine("Não é vogal");
    }

//bool ehMaiorDeIdade = false;
Console.WriteLine("Digite sua idade");
//int idade1 = Int32.Parse(Console.ReadLine());
int idade1 = Convert.ToInt32(Console.ReadLine());
bool possuiAutorizarcaoResponsavel = false;

if (idade1 >= 18){
    Console.WriteLine("Entrada Liberada!");
}else if (possuiAutorizarcaoResponsavel){
    Console.WriteLine("Entrada Liberada!");
}
else{
    Console.WriteLine("Entrada Não Liberada!");
}


// Operador && (and)
bool presencaMinina = true;
Console.WriteLine("Digite sua Nota1");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua Nota2");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua Nota3");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (presencaMinina && media >= 7.5 ){
    Console.WriteLine("Sua Media é " + media + " Aprovado ");
}else if (presencaMinina && media >= 5 && media < 7.5 ){
    Console.WriteLine("Sua Media é " + media + " Recuperação");
} else {
    Console.WriteLine("Sua Media é " + media + " Reprovado");
}


//Operador NOT (!)
bool choveu = true;
bool estaTarde = true;

//estou negando quando o ! esta na frente da variavel
if (!choveu && !estaTarde){
    Console.WriteLine("Vou Pedalar");
} else {
    Console.WriteLine("Vou Pedalar outro dia");
}


//instanciando a classe Calculadora 
Calculadora calc = new Calculadora();

Console.WriteLine("Digite um numero inteiro");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite um numero inteiro");
int s1 = Convert.ToInt32(Console.ReadLine());

//chamando as Operações
calc.Somar(s, s1);
calc.Subtrair(s,s1);
calc.Multiplicar(s,s1);
calc.Dividir(s,s1);
calc.Potencia(s,s1);

Calculadora grau = new Calculadora();
Console.WriteLine("Digite um angulo");
int graus = Convert.ToInt32(Console.ReadLine());

grau.Seno(graus);
grau.Coseno(graus);
grau.Tangente(graus);


//Icrementando e Demecremento 
Console.WriteLine("Digite um numero para Incrementar e Decrementar");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num++ + " Incrementando + 1 = " + num );

Console.WriteLine(num-- + " Decrementando - 1 = " + num );


//Raiz Quadrada 
Calculadora RzQuadarda = new Calculadora();
Console.WriteLine("Digite um Numero para raiz quadrada");
int rQuadrada = Convert.ToInt32(Console.ReadLine());

RzQuadarda.RaizQuadrada(rQuadrada);


//Laço For 
Console.WriteLine("Digite um Numero para tabuada com laço FOR ");
int tabuada = Convert.ToInt32(Console.ReadLine());

for (int contador = 0; contador <= 10; contador++){
    Console.WriteLine($"{tabuada} x {contador} = {tabuada * contador}");
}
         


//Laço While 
Console.WriteLine("Digite um Numero para tabuada com laço WHILE ");
int tabuada1 = Convert.ToInt32(Console.ReadLine());
int contador1 = 0;

while (contador1 <= 10){
    Console.WriteLine($"{tabuada1} x {contador1} = {tabuada1 * contador1}");
    contador1++;
}

//Do While
int soma1 = 0, numero = 0;

do {
    Console.WriteLine("Digite um numero para somar e (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma1 += numero;

} while(numero != 0); 

Console.WriteLine($"Total da soma dos numeros digitados é: {soma1}");


//Construindo um MENU 
string? opcao;
bool  exibirMenu = true;

//while(true)
while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");
   
   opcao = Console.ReadLine();

   switch (opcao)
   {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Buscar Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0); //Aquie ele ira sair do meu programa
            exibirMenu = false;
            break;

        default: 
            Console.WriteLine("Opção invaçida");
            break;            
   }

}

Console.WriteLine("O Programa se Encerrou");



//array e listas
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

//Percorrendo o array com o for
Console.WriteLine("Percorrendo o array com o for");
for (int contador2 = 0; contador2 < arrayInteiros.Length; contador2++)
{
    Console.WriteLine($"Array Posição N° {contador2}° - {arrayInteiros[contador2]}");
}

//Acessando um elemento do array
int elemento = arrayInteiros[2];
Console.WriteLine($"array de posição 2° equivale a dado de {elemento}");
Console.WriteLine(arrayInteiros[1]);


//Percorrendo o array com foreach
Console.WriteLine("Percorrendo o array com foreach");
int contadorForeach = 0;
foreach(int valor  in arrayInteiros)
{
    Console.WriteLine($"Posição {contadorForeach}° - {valor}");
    contadorForeach++;
}


//aumentando o tamanho do array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length + 1 );

//copiando os dados de um array para um novo array
//int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//Listas - A diferença entre o array é que não precisa passar o tamanho dessa lista 
//Muito melhor de se trabalhar pois tem mais metados
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");

Console.WriteLine("Percorrendo uma lista com o for");
for (int contador3 = 0; contador3 < listaString.Count; contador3++ )
{
    Console.WriteLine($"Posição na lista N° {contador3} - {listaString[contador3]}");
}

Console.WriteLine("Percorrendo uma lista com o foreach");
int contadorForeachLista = 0;
foreach(string item in listaString)
{
    Console.WriteLine(($"Posição na lista N° {contadorForeachLista} - {item}"));
    contadorForeachLista++;
}


