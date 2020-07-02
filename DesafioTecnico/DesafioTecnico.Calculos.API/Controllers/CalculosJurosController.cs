using DesafioTecnico.Calculos.API.Models;
using DesafioTecnico.Calculos.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DesafioTecnico.Calculos.API.Controllers
{
    [ApiController]
    public class CalculosJurosController : ControllerBase
    {
        private readonly IServicoCalculoJuros _servicoCalculoJuros;
        public CalculoJurosValidacaoModel CalculoJurosValidacaoModel { get; set; }

        public CalculosJurosController(IServicoCalculoJuros servicoCalculoJuros)
        {
            _servicoCalculoJuros = servicoCalculoJuros;
            CalculoJurosValidacaoModel = new CalculoJurosValidacaoModel();
        }

        [HttpGet("/calculaJuros")]
        public IActionResult Obter(string valorinicial, string meses)
        {
            if(!CalculoJurosValidacaoModel.Validar(valorinicial, meses))
                return BadRequest(CalculoJurosValidacaoModel.Erros.FirstOrDefault());

            decimal valorCalculado =
                _servicoCalculoJuros.CalcularJuros(CalculoJurosValidacaoModel.ValorInicial, CalculoJurosValidacaoModel.Meses);

            valorCalculado = TruncarValor(valorCalculado);

            return Ok(valorCalculado.ToString("0.00"));
        }

        private decimal TruncarValor(decimal valor)
        {
           return Math.Truncate(valor * 100) / 100;
        }
    }
}