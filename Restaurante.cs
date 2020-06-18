namespace ifood
{
    public class Restaurante
    {
       public string NomeFantasia { get; set; }
       public string Endereco { get; set; } 
       public bool AccPedido { get; set; }

       public string MostrarDados(string _nomeFantasia, string _endereco){
           this.NomeFantasia = _nomeFantasia;
           this.Endereco = _endereco;

           return $"Nome do restaurante: {_nomeFantasia}\nEndereço do restaurante: {_endereco}";
       }
    }
}