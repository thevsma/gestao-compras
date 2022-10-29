using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoComprasMVP
{
    internal class Produto
    {
        public Int64 Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public Produto()
        {
            Codigo = 0;
            Nome = "Sem nome";
            Preco = 0;
        }

        public Produto(Int64 codigo, String nome, Decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public override String ToString()
        {
            return String.Format("{0}, {1} [R${2}]", Codigo, Nome, Preco);
        }
    }
}
