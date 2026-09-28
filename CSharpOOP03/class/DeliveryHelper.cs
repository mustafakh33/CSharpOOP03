using CSharpOOP02.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP03
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment();
        }
    }
}
