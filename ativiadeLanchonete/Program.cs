using System;
using System.Collections.Generic;

namespace ativiadeLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Produto> cardapio = new List<Produto>
            {
                new Produto("X-Burger", 15.00m),
                new Produto("Batata Frita", 8.00m),
                new Produto("Refrigerante", 5.00m),
                new Produto("Sorvete", 6.00m),
                new Produto("Água", 3.00m)
            };

            
            Pedido pedido = new Pedido(1);

            
            bool continuarPedido = true;
            while (continuarPedido)
            {
                Console.WriteLine("\nCardápio:");
                for (int i = 0; i < cardapio.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {cardapio[i].Nome} - R$ {cardapio[i].Preco:F2}");
                }

                Console.Write("\nEscolha o número do produto que deseja adicionar ao pedido (ou 0 para finalizar): ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 0)
                {
                    continuarPedido = false;
                }
                else if (escolha > 0 && escolha <= cardapio.Count)
                {
                    pedido.AdicionarProduto(cardapio[escolha - 1]);
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }

            
            Console.WriteLine("\nResumo do Pedido:");
            pedido.ExibirDetalhes();
        }
    }
}
