﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    interface IPart
    {
        ISupplier Supplier { get; }
        string PartNumber { get; }
        string Manufacturer { get; }
    }
}
