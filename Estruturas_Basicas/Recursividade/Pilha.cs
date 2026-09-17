//estrutura da pilha
int[] Pilha = new int[5];
int topo = 0;

void Adicionar_item(int Valor)
{
    if (topo == Pilha.Length)
    {
        Console.WriteLine("Esta_cheia");
        return;
    }
    Pilha[topo] = Valor;
    topo++;
}

bool Esta_vazia()
{
    if (topo == 0)
    {
        return true;
    }
    return false;
}

int Remolver()
{
    if (!Esta_vazia())
    {
        topo--;
        return Pilha[topo];
    }
    return -1;

}

Adicionar_item(10);
Console.WriteLine(Remolver());
Console.WriteLine(Esta_vazia());
Console.WriteLine(Remolver());



// ============================================================
// EXERCÍCIO — SISTEMA DE PILHA
// ============================================================
// Crie um programa que utilize uma pilha implementada com vetor,
// sem usar a estrutura Stack pronta da linguagem.
//
// O programa deve possuir um menu para:
// 1) Testar a pilha
// 2) Inverter uma sequência
// 3) Adicionar um valor
// 4) Desfazer a última ação
// 5) Ver a última ação
// 6) Verificar se a pilha está vazia
// 7) Sair
//
// A pilha deve seguir o princípio LIFO.
// ============================================================

int opc = 0;

while( opc != 7)
{
    Console.WriteLine();
    Console.WriteLine("=====Menu=====");
    Console.WriteLine("1) Testar a pilha");
    Console.WriteLine("2) Inverter sequencia ");
    Console.WriteLine("====Exercicio 3====");
    Console.WriteLine("3) Adicionar na pilha");
    Console.WriteLine("4) Desfazer última ação");
    Console.WriteLine("5) Ver ultima ação");
    Console.WriteLine("6) Esta vazia");
    Console.WriteLine("7) sair");



    Console.Write("Digite sua opc: ");
    opc = Convert.ToInt32(Console.ReadLine());
     

    if (opc == 1)
    {
        Adicionar(10);
        Adicionar(20);
        Adicionar(30);
        Console.WriteLine(Esta_vazia());
        Console.WriteLine(Remover());
        Console.WriteLine(Remover());
        Console.WriteLine(Remover());
        Console.WriteLine();
    }

    if (opc == 2)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());  
            Adicionar(valor);
        }
        foreach (int valor in pilha)
        {
            Console.WriteLine($"valor = {Remover()}");
            
        }
    }
    if (opc == 3)
    {
        Console.WriteLine();
        Console.Write("Digite valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());  
        Adicionar(valor);
    }

    if (opc == 4)
    {
        Console.WriteLine($"Ação desfeita: {Remover()}");
        Console.WriteLine();
    }
    if (opc == 5)
    {
        Console.WriteLine($"Ação ultima: {Remover()}");
        topo++;
        Console.WriteLine();
    }
    if (opc == 6)
    {
        Console.WriteLine($"esta vazia {Esta_vazia()}");
        Console.WriteLine();
    }

}
