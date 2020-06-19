namespace ifood
{
    public class Restaurante
    {
       public string NomeFantasia { get; set; }
       public string Endereco { get; set; } 
       public bool AccPedido { get; set; }

       public string MostrarDados(){

           return $"Nome do restaurante: {NomeFantasia}\nEndereço do restaurante: {Endereco}\n";
       }
       public Restaurante(string _nomeFantasia){
           this.NomeFantasia = _nomeFantasia;
       }
    }
}