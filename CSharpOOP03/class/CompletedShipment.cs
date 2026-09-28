using CSharpOOP01;
using CSharpOOP02.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP03
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}
