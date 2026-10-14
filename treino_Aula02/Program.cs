//1 - Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
int notaMedia = 5;
if (notaMedia >= 5)
{
    Console.Write("Aluno aprovado");
}

//2 - Criar uma variável de texto chamada nomeAluno e atribuir um nome a ela. Exibir uma mensagem utilizando essa variável, como: "Olá, [nomeAluno]!".
string nomeAluno = "Felipe";
Console.WriteLine($"\nOlá, {nomeAluno}!");

//3 - Criar uma função que receba um número inteiro como parâmetro e retorne se ele é positivo, negativo ou zero.
Console.Write("\nEscolha um número para saber se é positivo, negativo ou zero: ");
string verificaNumero = Console.ReadLine();
int numero = int.Parse(verificaNumero);

switch (numero)
{
    case 0: Console.WriteLine("Este número é zero");
        break;
    case < 0: Console.WriteLine("Este número é negativo");
        break;
    case > 0: Console.WriteLine("Este número é positivo");
        break;
}
