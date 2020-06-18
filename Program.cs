using System;

namespace ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Restaurante restaurante = new Restaurante();
            Pedido pedido = new Pedido();

            Console.WriteLine("Cliente: ");
            Console.WriteLine(cliente.MostrarDados( "Tiago", "Jabaquara" ));

            Console.WriteLine();

            Console.WriteLine("Restaurante: ");
            Console.WriteLine(restaurante.MostrarDados( "Restaurante Feliz", "Conceição" ));  

            Console.WriteLine();

            pedido.Cliente = cliente.Nome;
            pedido.Restaurante = restaurante.NomeFantasia;
            Console.WriteLine(pedido.EntregarPedido("Batata Frita", "Cartão de Débito", true ));
        }
    }
}
