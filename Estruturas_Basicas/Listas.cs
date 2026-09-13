// ============================================================
// EXERCÍCIO 1 — VERIFICAR ESTOQUE
// Retornar produtos com quantidade menor que 3.
// ============================================================

List<string> VerificarEstoque(List<string> produtos, List<int> quantidades)
{
    int SizeList = Math.Min(produtos.Count, quantidades.Count);

    List<string> Lista_repor = new List<string>();

    for (int i = 0; i < SizeList; i++)
    {
        if (quantidades[i] < 3)
        {
            Lista_repor.Add($"{produtos[i]} = {quantidades[i]}");
        }
    }

    return Lista_repor;
}


List<string> produtos = new List<string>
{
    "Racao",
    "Shampoo",
    "Brinquedo",
    "Coleira",
    "Petisco"
};

List<int> quantidades = new List<int>
{
    2,
    10,
};

foreach (string item in VerificarEstoque(produtos, quantidades))
{
    Console.WriteLine(item);
}


// ============================================================
// EXERCÍCIO 2 — MAIOR SOMA
// Retornar a maior soma encontrada entre as sublistas.
// ============================================================

int Maior_soma(List<object> Lista)
{
    int soma;
    int maior_sub = 0;

    foreach (var num in Lista)
    {
        soma = 0;

        if (num is List<int> Sublista)
        {
            foreach (int valor in Sublista)
            {
                soma += valor;
            }
        }

        if (soma > maior_sub)
        {
            maior_sub = soma;
        }
    }

    return maior_sub;
}


List<object> Lista_sub = new List<object>
{
    1,
    2,
    new List<int> { -130 - 40, -50 },
    2,
    3,
    new List<int> { -10, -20, -50 },
    4,
    5,
    new List<int> { -10, -20, -30 }
};

Console.WriteLine(Maior_soma(Lista_sub));


// ============================================================
// EXERCÍCIO 3 — MAIOR SEQUÊNCIA
// Retornar o tamanho da maior sequência crescente.
// ============================================================

int MaiorSequencia(List<int> lista)
{
    if (lista.Count == 0)
        return 0;

    int maior = 1;
    int quantidade = 1;

    for (int i = 0; i < lista.Count - 1; i++)
    {
        if (lista[i] + 1 == lista[i + 1])
        {
            quantidade++;

            if (quantidade > maior)
                maior = quantidade;
        }
        else
        {
            quantidade = 1;
        }
    }

    return maior;
}


List<int> lista = new List<int>
{
    1,
    2,
    3,
    4
};

Console.WriteLine($"Maior sequência = {MaiorSequencia(lista)}");


// ============================================================
// EXERCÍCIO — ENCONTRAR PICOS
// Percorrer a lista e identificar valores maiores que
// seus dois vizinhos.
// ============================================================


List<int> List_Peaks(List<int> List_value)
{

    List<int> filter_peaks = new List<int>();

    for (int i = 0; i < List_value.Count - 2; i++)
    {
        if (List_value[i] < List_value[i + 1] && List_value[i+1] > List_value[i+2])
        {
            filter_peaks.Add(List_value[i+1]);
        }
    }
    return filter_peaks;
}

List<int> List_values = new List<int>{ 2, 5, 3, 8, 4, 6, 1 };

Console.Write("Valores de picos = ");
foreach (int value in List_Peaks(List_values))
{
    Console.Write(value);
}
