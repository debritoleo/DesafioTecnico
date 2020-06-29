namespace DesafioTecnico.Taxas.Business.Models
{
    public class Taxa
    {
        public Taxa() { }
        public Taxa(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; private set; }
    }
}
