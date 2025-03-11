using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace ativiadeLanchonete
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        
        public Pedido(int numeroPedido)
        {
            NumeroPedido = numeroPedido;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            
            Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido #{NumeroPedido}.");
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preco;
            }
            return total;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nPedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var produto in Produtos)
            {
                produto.MostrarProduto();
            }
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
        }
    }
} 