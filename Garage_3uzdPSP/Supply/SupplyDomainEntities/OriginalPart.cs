﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class OriginalPart : IPart
    {
        public string PartNumber { get; }

        public string Manufacturer { get; }

        public ISupplier Supplier { get; }

        public OriginalPart(string partNo, string manufacturer, ISupplier supplier)
        {
            PartNumber = partNo;
            Manufacturer = manufacturer;
            Supplier = supplier;
        }
    }
}
