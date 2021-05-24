using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Api.Commond.Responses
{
    public class GenericListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
