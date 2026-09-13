// Ex 1 - Remover números repetidos
// O programa deve percorrer uma lista de números e remover
// os valores repetidos, mantendo apenas a primeira ocorrência.

List<int> lista_repetida = [4, 7, 2, 4, 9, 7, 7, 3, 2, 8, 9, 1];

for (int i = 0; i < lista_repetida.Count; i++)
{
    for (int j = i + 1; j < lista_repetida.Count; j++)
    {
        if (lista_repetida[i] == lista_repetida[j])
        {
            lista_repetida.RemoveAt(j);
            j--;
        }
    }
}

for (int i = 0; i < lista_repetida.Count; i++)
{
    Console.Write(lista_repetida[i]);
}


// Ex 2 - Ordenar vetor
// O programa deve receber um vetor de números e organizá-lo
// em ordem crescente sem utilizar uma função pronta de ordenação.

int[] lista1 = [10, 5, 20, 30, 15];

Console.WriteLine(lista1.Length);

int c = 0;
int a = 0;
int b = 1;
int x = 0;

while (c != 4)
{
    if (lista1[a] > lista1[b])
    {
        x = lista1[a];
        lista1[a] = lista1[b];
        lista1[b] = x;
        c = 0;
    }
    else
    {
        c += 1;
    }

    a += 1;
    b += 1;

    if (b == lista1.Length)
    {
        a = 0;
        b = 1;
    }
}


// Ex 3 - Somatório de vetor
// O programa deve receber vários números em um vetor e,
// utilizando uma função recursiva, calcular o somatório dos valores.

int somatorio_vetor(int[] vetor, int contador, int soma)
{
    soma += vetor[contador];
    contador += 1;

    if (contador == vetor.Length)
    {
        return soma;
    }

    return somatorio_vetor(vetor, contador, soma);
}

int[] vetor = new int[5];

int valor;

for (int i = 0; i < 5; i++)
{
    Console.Write(i + " Digite Valor:");
    valor = Convert.ToInt32(Console.ReadLine());
    vetor[i] = valor;
}

Console.WriteLine(somatorio_vetor(vetor, 0, 0));


// Ex 4 - Maior, menor e média
// O programa deve armazenar 5 idades em um vetor e calcular
// a maior idade, a menor idade e a média das idades.

int[] lista = new int[5];

int SistemaIdades(int[] lista, int soma = 0)
{
    int maior = 0;
    int menor = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        lista[i] = idade;
        soma += idade;

        if (i == 0)
        {
            maior = idade;
            menor = idade;
        }

        if (idade > maior)
        {
            maior = idade;
        }

        if (idade < menor)
        {
            menor = idade;
        }
    }

    Console.WriteLine("maior {0}, menor {1}", maior, menor);

    return soma / lista.Length;
}

Console.WriteLine("Media das idades = {0}", SistemaIdades(lista));


// Ex 5 - Sequência de números pares e ímpares
// O programa deve criar um vetor com os números de 1 a 10
// e informar quais números são pares e quais são ímpares.

List<int> numbers = new List<int>();

for (int i = 1; i <= 10; i++)
{
    numbers.Add(i);
}

foreach (int number in numbers)
{
    if (number % 2 != 0)
    {
        Console.WriteLine($"numeros sequencia {number} impar");
    }
    else
    {
        Console.WriteLine($"Sequencia de numero {number} par");
    }
}
