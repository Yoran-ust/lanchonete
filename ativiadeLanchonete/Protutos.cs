using System;

namespace ativiadeLanchonete
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void MostrarProduto()
        {
            Console.WriteLine("Cardápio --------- ");
            Console.WriteLine($"Lanche: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine("------------------");
        }
    }
}