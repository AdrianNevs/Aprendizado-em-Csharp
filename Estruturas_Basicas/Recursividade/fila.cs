// EXERCÍCIO: Fila Estática de Inteiros
//
// Enunciado:
// Crie um programa que leia 10 números inteiros informados pelo usuário 
// e os insira em uma fila estática. Em seguida, desempilhe/remova todos 
// os elementos da fila um a um para calcular e exibir:
//
// 1. O maior valor digitado;
// 2. O menor valor digitado;
// 3. A média aritmética dos valores.

int[] fila = new int[10];
int inicio = 0,fim = 0;

void Adicionar_fila(int valor)
{
    fila[fim] = valor;
    fim++ ;
    
}

int remove()
{
    inicio++;
    return fila[inicio - 1];
}


string maior_menor_media()
{
    int maior = 0;
    int menor = 0;
    int soma = 0;
    int valor;
    int numero;

    for(int i = 0;i < 10; i++)
    {
        Console.Write($"[{i}]Digite valor: ");
        valor = Convert.ToInt32(Console.ReadLine());
        Adicionar_fila(valor);
    }
    for (int i = 0; i < fila.Length;i++)
    {
        numero = remove();
        soma += numero; //somar valores da lista

        if (i == 0)
        {
            maior = numero;
            menor = numero;
        }

        if (maior < numero)
        {
            maior = numero;
        }
        if (menor > numero)
        {
            menor = numero;
        }

    }

    return $"Maior = {maior}, Menor = {menor}, Media = {soma / fila.Length}";
}


Console.WriteLine(maior_menor_media());


// EXERCÍCIO — FILA PREFERENCIAL
// Simule uma fila de atendimento usando Dictionary<string, int>.
// 1 = atendimento preferencial | 0 = atendimento comum.
// Atenda primeiro todos os preferenciais, respeitando a ordem de chegada.
// Após finalizar os preferenciais, atenda os clientes comuns.
// Remova cada pessoa da fila após o atendimento.

Dictionary<string,int> List_person = new Dictionary<string, int> {{"adrian",0},{"moises",1},{"Galileu",0},{"moana",1},{"ana Flavia",1}};

void Fila_ordem(Dictionary<string,int> List_person)
{
    int i = 0;

    while (List_person.Count != 0)
    {
        
        
        
        if (List_person.ElementAt(i).Value == 1 && List_person.Count(x => x.Value == 1) > 0)
        {
            Console.WriteLine($"foi atendido = {List_person.ElementAt(i).Key}");
            List_person.Remove(List_person.ElementAt(i).Key);
            i--;
            
        }
        if (!(List_person.Count(x => x.Value == 1) > 0))
        {
            i = 0;
            
        }

        if (List_person.ElementAt(i).Value == 0 && !(List_person.Count(x => x.Value == 1) > 0))
        {
            Console.WriteLine($"foi atendido = {List_person.ElementAt(i).Key}");
            List_person.Remove(List_person.ElementAt(i).Key);
            i--;
        }
        Console.WriteLine(i);
        i++;

        
    }

}
Fila_ordem(List_person);
