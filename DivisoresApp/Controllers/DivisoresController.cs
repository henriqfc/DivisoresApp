using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DivisoresApp.Funcoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DivisoresApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisoresController : ControllerBase
    {
        [HttpGet("{numero}")]
        public ActionResult<Dictionary<string, List<int>>> Get(int numero)
        {
            Dictionary<string, List<int>> retorno = new Dictionary<string, List<int>>();
            Divisores dClass = new Divisores();
            var divisores = dClass.retornaDivisores(numero);
            retorno.Add("Divisores", divisores);
            var divPrimos = dClass.retornaPrimos(divisores);
            retorno.Add("DivisoresPrimos", divPrimos);
            return Ok(retorno);
        }
    }
}
