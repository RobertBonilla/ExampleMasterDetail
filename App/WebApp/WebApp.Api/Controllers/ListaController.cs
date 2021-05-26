using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Core.Interfaces;
using WebApp.Api.Commond.Responses;
using WebApp.Core.Domain;
using System.Net;

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
        public GenericListResponse<Lista> GetLista()
        {
            GenericListResponse<Lista> reponse;
            try
            {
                reponse = new GenericListResponse<Lista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Items = _userCase.ObtenerLista()
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericListResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError,Message = ex.ToString() }
                };
            }            
            return reponse;
        }

        [HttpGet("GetListaModel")]
        public GenericResponse<Lista> GetListaModel(int id)
        {
            GenericResponse<Lista> reponse;
            try
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.GetLista(new Lista() { ListaId = id })
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }

        [HttpPost("modificarLista")]
        public GenericResponse<Lista> modificarLista(Lista model)
        {
            GenericResponse<Lista> reponse;
            try
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.ModificarLista(model)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }

        [HttpPost("insertarLista")]
        public GenericResponse<Lista> insertarLista(Lista model)
        {
            GenericResponse<Lista> reponse;
            try
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _userCase.InsertarLista(model)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return reponse;
        }
    }
}
