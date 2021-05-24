using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Core.Interfaces;

namespace WebApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaController : ControllerBase
    {
        private readonly IListaUserCase _userCase;
        public ListaController(IListaUserCase userCase)
        {
            _userCase = (userCase != null) ? userCase : throw new ArgumentNullException(nameof(userCase));
        }
        [HttpGet("GetLista")]
        public string GetLista()
        {
            var objeto = _userCase.ObtenerLista();
            return "Hola Mundo";
        }
    }
}
