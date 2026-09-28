using CSharpOOP01;
using CSharpOOP02.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP02
{
    public class InternationalShipment : Shipment
    {
        private string _destinationCountry = string.Empty;
        private decimal _customsFee;

        public string DestinationCountry
        {
            get => _destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get => _customsFee;
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + CustomsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        // GenerateCustomsReport()
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report...");
        }

        // PrintShipment() ← Country + CustomsFee
        public override void PrintShipment()
        {
            base.PrintShipment();

            Console.WriteLine($"  DestinationCountry : {DestinationCountry}");
            Console.WriteLine($"  CustomsFee         : {CustomsFee:C}");

        }
    }
}
