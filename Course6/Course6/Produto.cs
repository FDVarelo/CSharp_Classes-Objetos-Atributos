using System;
using System.Globalization;

namespace Course6
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidade(int valor)
        {
            Quantidade += valor;
        }
        public void DiminuirQuantidade(int valor)
        {
            Quantidade -= valor;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
