using DesafioTecnico.Calculos.API.Utils;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Calculos.API.Controllers
{
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet("/showmethecode")]
        public string Obter()
        {
            return Constantes.URL_GITHUB;
        }
    }
}