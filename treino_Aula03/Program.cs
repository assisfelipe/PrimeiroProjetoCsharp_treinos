//1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

float a = 5;
float b = 2;

float soma = a + b;
float subtracao = a - b;
float divisao = a / b;
float multiplicacao = a * b;

Console.WriteLine($"a + b = {soma}");
Console.WriteLine($"a - b = {subtracao}");
Console.WriteLine($"a / b = {divisao}");
Console.WriteLine($"a * b = {multiplicacao}");

//2 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> listaBandas = new List<string>();

listaBandas.Add("\nSlipknot");
listaBandas.Add("Linkin Park");
listaBandas.Add("Metallica");

//3 - Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

for (int i = 0; i < listaBandas.Count; i++)
{
    Console.WriteLine(listaBandas[i]);
}

//4 - Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int somaElementos = 0;

foreach (int numero in numeros)
{
    somaElementos += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}\n");

// Faça como eu fiz

List<int> numerosLista2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numerosLista2.Count; i++)
{
    if (numerosLista2[i] % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine(numerosLista2[i]);
    }
}

foreach (int numero in numerosLista2)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}