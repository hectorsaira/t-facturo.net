﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;

namespace SOAPServices.Persistencia
{
    public class FacturaDAO : BaseDAO<Factura, int>
    {
    }

    public class FacturaDetalleDAO : BaseDAO<FacturaDetalle, FacturaDetallePK>
    {
    }
}