using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Frontend.Models.Domain;
using WebApp.Frontend.Models.Dto;
using WebApp.Frontend.Rest.Interfaces;
using WebApp.Frontend.Rest.Reponses;

namespace WebApp.Frontend.Controllers
{
    public class ListaController : Controller
    {
        private readonly IApiRest _apiRest;
        public ListaController(IApiRest apiRest)
        {
            _apiRest = (apiRest != null) ? apiRest : throw new ArgumentNullException(nameof(apiRest));
        }
        public IActionResult Index()
        {
            GenericListResponse<Lista> result = _apiRest.getLista();
            ViewData["Lista"] = result.Items;
            return View();
        }
        public IActionResult Detail(int id)
        {
            GenericResponse<ListaItems> result = _apiRest.getListaData(id);
            ViewData["ListaModel"] = result.Item;
            if (result.Item == null) RedirectToAction("Index");
            return View();
        }
        public IActionResult Edit(int id)
        {
            GenericResponse<Lista> result = _apiRest.getListaModel(id);
            ViewData["ListaModel"] = result.Item;
            if (result.Item == null) RedirectToAction("Index");
            return View();
        }       
        public string ModificarLista(string descripcion, int id)
        {
            GenericResponse<Lista> result = _apiRest.modificarLista(new Lista() { Descripcion = descripcion, ListaId = id });
            if (result.Item != null) return "OK";
            return "F";
        }

        public string EliminarDetalle(int id)
        {
            GenericResponse<detLista> result = _apiRest.eliminarDetail(new detLista() {  DetListaId = id });
            if (result.Item != null) return "OK";
            return "F";
        }
    }
}
