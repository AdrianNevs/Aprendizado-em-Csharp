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

}

Adicionar_item(10);
Console.WriteLine(Remolver());
Console.WriteLine(Esta_vazia());
Console.WriteLine(Remolver());
