// ============================================================
// EXERCÍCIO 1 — POTÊNCIA
// Calcular x elevado a y usando recursividade.
// ============================================================

int Potencia(int x, int y, int Cont = 1, int x1 = 0)
{
    if (Cont == 1)
    {
        x1 = x;
    }

    if (Cont < y)
    {
        x *= x1;
        return Potencia(x, y, Cont + 1, x1);
    }

    return x;
}


// ============================================================
// EXERCÍCIO 2 — CUBOS
// Exibir os cubos dos números de 1 até n.
// ============================================================

void cubos(int n)
{
    cubo_auxilar(1, n);
}


void cubo_auxilar(int i, int n)
{
    if (i <= n)
    {
        Console.WriteLine(i * i * i);
        cubo_auxilar(i + 1, n);
    }
}


// ============================================================
// EXERCÍCIO 3 — EUCLIDES
// Encontrar o MDC de dois números usando recursividade.
// ============================================================

int mdc_euclides(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    else if (x < y)
    {
        return mdc_euclides(y, x);
    }
    else
    {
        return mdc_euclides(x - y, y);
    }
}


// ============================================================
// EXERCÍCIO 4 — FIBONACCI
// Calcular o n-ésimo termo da sequência de Fibonacci.
// ============================================================

int Fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}


// ============================================================
// EXERCÍCIO 5 — BINÁRIO
// Converter um número decimal para binário usando recursividade.
// ============================================================

void binario(int n)
{
    if (n > 1)
        binario(n / 2);

    Console.Write(n % 2);
}


// ============================================================
// MENU
// ============================================================

int opc = 0;

while (opc != 6)
{
    Console.WriteLine("===Menu===");
    Console.WriteLine("1) potencia");
    Console.WriteLine("2) cubos");
    Console.WriteLine("3) Fibonacci");
    Console.WriteLine("4) Binario");
    Console.WriteLine("5) Euclides");
    Console.WriteLine("6) Sair");
    Console.WriteLine("");
    Console.Write("Digite: ");

    opc = Convert.ToInt32(Console.ReadLine());

    if (opc == 1)
    {
        Console.Write("Digite Valor X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite Valor y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"valor = {Potencia(x, y)}");
    }

    if (opc == 2)
    {
        Console.Write("Digite Valor X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        cubos(x);
    }

    if (opc == 3)
    {
        Console.Write("Digite Valor X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"valor = {Fibonacci(x)}");
    }

    if (opc == 4)
    {
        Console.Write("Digite Valor X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x == 0)
        {
            Console.WriteLine("valor = 0");
        }
        else
        {
            binario(x);
            Console.WriteLine("");
        }
    }

    if (opc == 5)
    {
        Console.Write("Digite Valor X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite Valor y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"valor = {mdc_euclides(x, y)}");
    }
}
```
