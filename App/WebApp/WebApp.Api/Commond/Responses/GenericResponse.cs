using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Api.Commond.Responses
{
    public class GenericResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T Item { get; set; }
    }
}
