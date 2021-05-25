using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApp.Api.Commond.Responses;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoUserCase _userCase;
        public ProductoController(IProductoUserCase userCase)
        {
            _userCase = (userCase != null) ? userCase : throw new ArgumentNullException(nameof(userCase));
        }
        [HttpGet("GetLista")]
        public GenericListResponse<Producto> GetLista()
        {
            GenericListResponse<Producto> reponse;
            try
            {
                reponse = new GenericListResponse<Producto>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Items = _userCase.GetProductos()
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericListResponse<Producto>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }
    }
}
