﻿
//Programado por HeroRickyGames

using System.Globalization;

namespace LojaXExemplo {
    class program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("//Programado por HeroRickyGames!");
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");

            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}