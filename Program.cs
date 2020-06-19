using System;

namespace ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente tiago = new Cliente("Tiago");
            tiago.EnderecoAtual = "Jabaquara";
            Console.WriteLine( tiago.MostrarDados() );

            Restaurante subway = new Restaurante("Subway");
            subway.Endereco = "Plaza Sul";
            Console.WriteLine( subway.MostrarDados() );

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = tiago;
            pedido1.Restaurante = subway;
            
            pedido1.FazerPedido();

            Console.WriteLine();

            Console.WriteLine( pedido1.EntregarPedido() );
        }
    }
}
