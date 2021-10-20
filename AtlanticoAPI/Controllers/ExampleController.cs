using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtlanticoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {

        /// <summary>
        /// Consegues invocar ao chamar por exemplo o http://localhost:56989/api/example/getcards
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCards")]
        public IActionResult GetCards()
        {
            //assume que existe um mecanismo de autenticação e já sabes quem é o user que tem sessão
            var clientId = "1234578";

            var cardService = new CardsService();
            var cardList = cardService.GetUserCards(clientId);

            return Ok(cardList);

        }


        [HttpGet("GetCardsMasked")]
        public IActionResult GetCardsMasked()
        {
            //assume que existe um mecanismo de autenticação e já sabes quem é o user que tem sessão
            var clientId = "1234578";

            var cardService = new CardsService();
            var cardList = cardService.GetMaskedUserCards(clientId);

            return Ok(cardList);

        }



    }
}
