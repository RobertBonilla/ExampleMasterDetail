using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApp.Api.Commond.Responses;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaDetalleController : ControllerBase
    {
        private readonly IDetListaUserCase _userCase;
        public ListaDetalleController(IDetListaUserCase userCase)
        {
            _userCase = (userCase != null) ? userCase : throw new ArgumentNullException(nameof(userCase));
        }

        [HttpGet("Get")]
        public GenericResponse<ListaItems> Get(int ListaId)
        {
            GenericResponse<ListaItems> reponse;
            try
            {
                reponse = new GenericResponse<ListaItems>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.getListaProductos(new Lista() { ListaId = ListaId })
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<ListaItems>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }

        [HttpPost("add")]
        public GenericResponse<detLista> add(detLista model)
        {
            GenericResponse<detLista> reponse;
            try
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.insertarDetLista(model)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }

        [HttpPost("edit")]
        public GenericResponse<detLista> edit(detLista model)
        {
            GenericResponse<detLista> reponse;
            try
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.modificarDetLista(model)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }

        [HttpPost("delete")]
        public GenericResponse<detLista> delete(detLista model)
        {
            GenericResponse<detLista> reponse;
            try
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.eliminarDetLista(model)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<detLista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }
    }
}
