using DesafioTecnico.Taxas.Business.Models;

namespace DesafioTecnico.Taxas.Test.API.Factories
{
    public static class TaxaJurosFactory
    {
        public static Taxa TaxaEntidade_ObterTaxa()
        {
            return new Taxa(0.01m);
        }
    }
}
