using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Frontend.Models.Domain;
using WebApp.Frontend.Models.Dto;
using WebApp.Frontend.Rest.Interfaces;
using WebApp.Frontend.Rest.Reponses;

namespace WebApp.Frontend.Rest
{
    public class ApiRest : IApiRest
    {
        private readonly IConfiguration _configuration;
        private readonly string UrlBase;
        public ApiRest(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
            UrlBase = _configuration.GetConnectionString("ApiBack");
        }
        
        public GenericListResponse<Lista> getLista()
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Lista/GetLista", Method.GET);
            restRequest.Timeout = 600000;
            var restResponse = rest.Execute<GenericListResponse<Lista>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<Lista> getListaModel(int id)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Lista/GetListaModel?id="+id, Method.GET);
            restRequest.Timeout = 600000;
            var restResponse = rest.Execute<GenericResponse<Lista>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<ListaItems> getListaData(int ListaId)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/ListaDetalle/Get?ListaId="+ListaId, Method.GET);
            restRequest.Timeout = 600000;
            var restResponse = rest.Execute<GenericResponse<ListaItems>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<Lista> modificarLista(Lista model)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Lista/modificarLista", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddBody(model);
            var restResponse = rest.Execute<GenericResponse<Lista>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<detLista> eliminarDetail(detLista model)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/ListaDetalle/delete", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddBody(model);
            var restResponse = rest.Execute<GenericResponse<detLista>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }
    }
}
