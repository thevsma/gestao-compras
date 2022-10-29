using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoComprasMVP
{
    internal class Compra
    {
        public static Int64 Serial { get; private set; }
        public Int64 Lote { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime Vencimento { get; set; }
        public Int16 Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Decimal Total
        {
            get
            {
                return CalcularTotal();
            }
        }

        static Compra()
        {
            Serial = 1;
        }

        public Compra()
        {
            Lote = Serial;
            Serial += 1;
        }

        public Compra(DateTime dataC, DateTime venc, Int16 quant, Produto prod) : this()
        {
            DataCompra = dataC;
            Vencimento = venc;
            Quantidade = quant;
            Produto = prod;
        }

        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        public override String ToString()
        {
            return String.Format("Lote {0}, {1} x {2}\nValor total: R${3}", Lote, Quantidade, Produto.Nome, CalcularTotal());
        }
    }
}
