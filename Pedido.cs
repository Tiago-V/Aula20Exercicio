using System;

namespace ifood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public DateTime Horario { get; set; }

        public string FazerPedido(){
            
            

            Console.WriteLine("Monte seu lanche: ");
            
            Itens = Console.ReadLine();

            return Itens ;
        }

        public string EntregarPedido(){

            Horario = DateTime.Now;

            Console.WriteLine("Pedido: "+Itens);

            string retorno = "Pedido Entregue!\n";
            retorno += Restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();
            retorno += Horario;
            
            return retorno;
        }
    }
}