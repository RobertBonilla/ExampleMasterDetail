﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;

namespace WebApp.Core.Interfaces
{
    public interface IProductoUserCase
    {
        IEnumerable<Producto> GetProductos();
    }
}
