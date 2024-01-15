
//Programado por HeroRickyGames

namespace LojaXExemplo {
    internal class Produto {
        public String Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }
    }
}
