using DesafioTecnico.Taxas.Business.Interfaces;
using DesafioTecnico.Taxas.Business.Models;

namespace DesafioTecnico.Taxas.Business.Servicos
{
    public class ServicoTaxa : IServicoTaxa
    {
        public Taxa ObterTaxa()
        {
            return new Taxa(0.01m);
        }
    }
}
