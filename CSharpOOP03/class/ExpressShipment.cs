using CSharpOOP01;
using CSharpOOP02.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP02
{
    public class ExpressShipment : Shipment
    {

        private decimal _extraFee;

        public decimal ExtraFee
        {
            get => _extraFee;
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + ExtraFee;
            }
        }

       public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            base.PrintShipment();

            Console.WriteLine($"  ExtraFee     : {ExtraFee:C}");

        }
    }
}
