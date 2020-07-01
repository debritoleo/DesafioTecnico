using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnico.Calculos.API.Models
{
    public class CalculoJurosValidacaoModel
    {
        public CalculoJurosValidacaoModel()
        {
            Erros = new List<string>();
        }

        public List<string> Erros { get; set; }
        public bool Valido => !Erros.Any();
        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }

        public bool Validar(string valorInicial, string meses)
        {
            if (string.IsNullOrEmpty(valorInicial))
                Erros.Add("Informe o valor inicial");

            if (!decimal.TryParse(valorInicial, out decimal valorInicialValido))
                Erros.Add("Informe um número válido para valor inicial");

            if (string.IsNullOrEmpty(meses))
                Erros.Add("Informe o número de meses");

            if (!int.TryParse(meses, out int mesesValido))
                Erros.Add("Meses deve ser um número válido");

            if (mesesValido > 12 || mesesValido < 1)
                Erros.Add("Meses deve ser um número válido");

            if (Valido)
            {
                ValorInicial = valorInicialValido;
                Meses = mesesValido;
            }

            return Valido;
        }
    }
}
