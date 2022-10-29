using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoComprasMVP
{
    internal class BDSimulado
    {
        public static BindingList<Compra> Lotes { get; set; }
        public static List<Produto> Produtos { get; set; }

        static BDSimulado()
        {
            Produtos = new List<Produto>();
            Lotes = new BindingList<Compra>();

            Produtos.Add(new Produto(1, "Banana", 6.12m));
            Produtos.Add(new Produto(2, "Maçã", 3.54m));
            Produtos.Add(new Produto(3, "Leite", 8.14m));
            Produtos.Add(new Produto(4, "Aveia", 9.55m));
            Produtos.Add(new Produto(5, "Whey", 96.00m));
            Produtos.Add(new Produto(6, "Batata", 2.59m));
            Produtos.Add(new Produto(7, "Mamão", 5.31m));
            Produtos.Add(new Produto(8, "Abacaxi", 7.12m));
            Produtos.Add(new Produto(9, "Cenoura", 5.98m));
            Produtos.Add(new Produto(10, "Beterraba", 4.45m));
            Produtos.Add(new Produto(11, "Morango", 13.17m));
            Produtos.Add(new Produto(12, "Iogurte", 3.15m));
            Produtos.Add(new Produto(13, "Suco Laranja", 4.98m));
            Produtos.Add(new Produto(14, "Achocolatado", 7.99m));
            Produtos.Add(new Produto(15, "Danix", 2.49m));
            Produtos.Add(new Produto(16, "Snickers", 2.39m));
            Produtos.Add(new Produto(17, "Heineken", 9.69m));
            Produtos.Add(new Produto(18, "Absolut", 109.17m));
            Produtos.Add(new Produto(19, "Corote", 4.99m));
            Produtos.Add(new Produto(20, "Stella Artois", 8.39m));
        }

        public static List<Produto> LocalizarNome(String parte)
        {
            List<Produto> pesquisa = new List<Produto>();

            foreach(Produto p in Produtos)
            {
                if (p.Nome.ToLower().Contains(parte.ToLower()))
                {
                    pesquisa.Add(p);
                }
            }
            return pesquisa;
        }
        
        public static Produto LocalizarCod(Int64 cod)
        {
            Produto pesquisa = new Produto();

            foreach(Produto p in Produtos)
            {
                if(p.Codigo == cod)
                {
                    pesquisa = p;
                }
            }
            return pesquisa;
        }

        public static BindingList<Compra> Vencimento(Int16 venc)
        {
            BindingList<Compra> pesquisa = new BindingList<Compra>();

            foreach(Compra c in BDSimulado.Lotes)
            {
                if((c.Vencimento.Date - DateTime.Now.Date).Days <= venc)
                {
                    pesquisa.Add(c);
                }
            }
            return pesquisa;
        }

        public static BindingList<Compra> VencPers(DateTime venc1, DateTime venc2)
        {
            BindingList<Compra> pesquisa = new BindingList<Compra>();

            foreach(Compra c in BDSimulado.Lotes)
            {
                if(c.Vencimento >= venc1 && c.Vencimento <= venc2)
                {
                    pesquisa.Add(c);
                }
            }
            return pesquisa;
        }
    }
}
