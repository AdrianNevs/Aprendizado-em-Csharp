// ============================================================
// EXERCÍCIO 3 — TOTALIZAR VENDAS POR PRODUTO
// Receba uma List<string> no formato "Produto: Quantidade".
// Some as quantidades de cada produto e retorne um
// Dictionary<string, int> contendo o total vendido por produto.
// Use foreach e Dictionary<string, int>, sem LINQ/GroupBy.
// ============================================================


Dictionary<string,int> Produtos_vendidos(List<string> Produtos)
{
    Dictionary<string,int> Dic_produtos = new Dictionary<string, int>();
    foreach (string item in Produtos)
    {
        string[] separar = item.Split(' ');
        if (!Dic_produtos.ContainsKey(separar[0]))
        {
            Dic_produtos.Add(separar[0],Convert.ToInt32(separar[1]));
        }
        else
        {
            Dic_produtos[separar[0]] += Convert.ToInt32(separar[1]);
        }
    }
    return Dic_produtos;
}

List<string> vendas = new List<string>
{
    "Ração: 30",
    "Brinquedo: 15",
    "Ração: 20",
    "Shampoo: 25",
    "Brinquedo: 10",
    "Shampoo: 15"
};
foreach (var item in Produtos_vendidos(vendas))
{
    Console.WriteLine($"key = {item.Key} value = {item.Value}");

}

Console.WriteLine();

// ============================================================
// EXERCÍCIO 2 — CONTAGEM DE OCORRÊNCIAS
// Receba uma lista de palavras e retorne um Dictionary onde
// cada chave é uma palavra e o valor é a quantidade de vezes
// que ela aparece na lista.
// ============================================================

Dictionary<string,int> Contar_palavras(List<string> Produtos)
{
    Dictionary<string,int> Produtos_dic = new Dictionary<string, int>();
    foreach (string item in Produtos)
    {
        if (!Produtos_dic.ContainsKey(item))
        {
            Produtos_dic.Add(item,1); // preciso por para certificar que todos iniciaram com 1 item
        }
        else
        {
            Produtos_dic[item]++; // adicionando +1 no valor da chave 
        }
    }
    return Produtos_dic;
}

List<string> palavras = new List<string>
{
    "racao",
    "brinquedo",
    "racao",
    "coleira",
    "racao",
    "brinquedo"
};

foreach (var item in Contar_palavras(palavras))
{
    Console.WriteLine($"key = {item.Key} value = {item.Value}");
}
// ============================================================
Console.WriteLine();


// ============================================================
// EXERCÍCIO 2 — CONTAGEM DE OCORRÊNCIAS USANDO COUNT
// Receba uma lista de palavras e retorne um Dictionary onde
// cada chave é uma palavra e o valor é a quantidade de vezes
// que ela aparece na lista.
// ============================================================

Dictionary<string,int> Contar_Com_Count(List<string> Produtos)
{
    Dictionary<string,int> Produtos_dic = new Dictionary<string, int>();
    foreach (var item in Produtos)
    {
        if (!Produtos_dic.ContainsKey(item))
        { 
            Produtos_dic.Add(item,Produtos.Count( x => x == item));
        }
    }
    return Produtos_dic;
}

List<string> palavras1 = new List<string>
{
    "racao",
    "brinquedo",
    "racao",
    "coleira",
    "racao",
    "brinquedo"
};

foreach (var item in Contar_Com_Count(palavras))
{
    Console.WriteLine($"key = {item.Key} value = {item.Value}");
}
// ============================================================
Console.WriteLine();

// ============================================================
// EXERCÍCIO 1 — TOTALIZAR VENDAS
// Receba uma List<string> no formato "Produto: Valor".
// Some o total de cada produto usando Dictionary<string, int>.
// Use foreach e não use LINQ/GroupBy.
// ============================================================

Dictionary<string,int> Atualizar_Estoque(Dictionary<string,int> estoque1,Dictionary<string,int> estoque2)
{
    Dictionary<String,int> Estoque = new Dictionary<string, int>();

    foreach(var item in estoque1)
{
    if (estoque2.ContainsKey(item.Key)){
        Estoque.Add(item.Key,item.Value + estoque2[item.Key]);
    }
    else
    {
        Estoque.Add(item.Key,item.Value);
    }
}
    foreach(var item in estoque2)
    {
        if (!estoque1.ContainsKey(item.Key))
        {
            Estoque.Add(item.Key,item.Value);
        }
    }

    
    return Estoque;
}



Dictionary<string, int> estoque1 = new Dictionary<string, int>
{
    {"Racao", 10},
    {"Brinquedo", 5},
    {"Shampoo", 3},
    {"pó",10}
};

Dictionary<string, int> estoque2 = new Dictionary<string, int>
{
    {"Racao", 7},
    {"Shampoo", 4},
    {"Coleira", 8}
};

foreach (var item in Atualizar_Estoque(estoque1,estoque2))
{
    Console.WriteLine($"{item.Key} {item.Value}");  
}

// ============================================================
// ============================================================
