﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Core.Domain
{
    public class detLista
    {
        public int DetListaId { get; set; }
        public int ListaId { get; set; }
        public int ProductoId { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
