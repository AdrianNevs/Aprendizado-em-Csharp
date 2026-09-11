// Ex 1 - Matriz
// O programa deve criar uma matriz com 2 linhas e 3 colunas,
// preencher a matriz com os valores das colunas e depois
// exibir a matriz na tela com seus [] de forma facil para visualizar.

int[][] matriz = new int[2][];

for (int i = 0; i < 2; i++)
{
    int[] linha = new int[3];

    for (int j = 0; j < 3; j++)
    {
        linha[j] = j;
    }

    matriz[i] = linha;
}

bool primeira_linha = true;

foreach (int[] linha in matriz)
{
    if (!primeira_linha)
    {
        Console.Write(",");
    }

    Console.Write("[");

    foreach (int numero in linha)
    {
        Console.Write(numero);
    }

    Console.Write("]");

    primeira_linha = false;
}

Console.WriteLine();
