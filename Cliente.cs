namespace ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }
        public string Pedido { get; set; }

        public string MostrarDados(string _nome, string _enderecoAtual){
            this.Nome = _nome;
            this.EnderecoAtual = _enderecoAtual;

            return $"Nome do cliente: {_nome}\nEndereço do cliente: {_enderecoAtual}";
        }
        public void FazerPedido(){

            System.Console.WriteLine("Faça o pedido.");
            Pedido = System.Console.ReadLine();

        }
    }
}