ExibirMensagem();

double media = CalcularMedia(8, 7, 9);

Console.WriteLine("Nota 1: 8");
Console.WriteLine("Nota 2: 7");
Console.WriteLine("Nota 3: 9");
Console.WriteLine("Média: " + media);

void ExibirMensagem()
{
    Console.WriteLine("Estou aprendendo C# e criando minhas primeiras funções!");
}

double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}