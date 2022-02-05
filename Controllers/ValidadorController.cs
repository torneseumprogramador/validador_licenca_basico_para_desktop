using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_validador_binario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_validador_binario.Controllers
{
    [ApiController]
    public class ValidadorController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public dynamic Index()
        {
            return new {
                Mensagem = "Api de validação de sistema Desktop"
            };
        }

        [HttpPost]
        [Route("/validar")]
        public dynamic Validar([FromBody] Licenca licenca)
        {
            List<string> licencas = new List<string>();
            licencas.Add("2039433ndfddsd2321");
            licencas.Add("@1212243212nssd");
            licencas.Add("459393n2n21odfcoi32n");
            licencas.Add("343i22n2m1k11");
            licencas.Add("4323232dssddssd");

            if(licencas.Contains(licenca.Chave)){
                return new {
                    Sucesso = true
                };
            }

            return new {
                Sucesso = false
            };
        }
    }
}
