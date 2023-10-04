//Inicializacao basica do for, variavel, condicao, incremento.

for (int i= 0; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// for aninhado criando uma tabela de multiplicacao.

for (int i = 1; i < 11; i++)
{
    for (int j = 0; j < 11; j++)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
    Console.WriteLine();
}