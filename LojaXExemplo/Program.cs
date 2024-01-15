
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

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}