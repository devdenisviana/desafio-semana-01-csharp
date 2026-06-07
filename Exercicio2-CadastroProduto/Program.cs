string nomeProduto = "Teclado Mecânico";
decimal preco = 250.00m;
int quantidade = 15;

Console.WriteLine("Produto " + nomeProduto);
Console.WriteLine("Preço: R$ " + preco.ToString("F2")); //ToString converte o decimal para string para juntar com o Preço: R$ e o valor. F2 é fixed-point, com 2 casas decimais.
Console.WriteLine("Quantidade: " + quantidade);