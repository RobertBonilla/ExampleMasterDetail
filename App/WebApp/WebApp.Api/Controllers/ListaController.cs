using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaController : ControllerBase
    {
        public ListaController()
        {

        }
        [HttpGet("GetLista")]
        public string GetLista()
        {
            return "Hola Mundo";
        }
    }
}
