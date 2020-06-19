namespace ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }
        public string Pedido { get; set; }

        public Cliente(string _nome){
            this.Nome = _nome;
        }
        public string MostrarDados(){

            return $"Nome do cliente: {Nome}\nEndereço do cliente: {EnderecoAtual}\n";
        }
        public void FazerPedido(){

            System.Console.WriteLine("Faça o pedido.");
            Pedido = System.Console.ReadLine();

        }
    }
}