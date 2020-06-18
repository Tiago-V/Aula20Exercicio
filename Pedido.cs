namespace ifood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }

        public string EntregarPedido(string _itens, string _formaDePGTO, bool _pedidoPago){
            this.Itens = _itens;
            this.FormaDePGTO = _formaDePGTO;
            this.PedidoPago =  _pedidoPago;

            return $"Sobre o Pedido\n\nItens: {_itens}\nCliente: {Cliente}\nRestaurante: {Restaurante}\n\nStatus do Pedido\n\nForma de pagamento: {_formaDePGTO}\nPago: {_pedidoPago}";
        }
    }
}