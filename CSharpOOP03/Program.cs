using CSharpOOP01;
using CSharpOOP02;
using CSharpOOP02.@class;
using System.Drawing;
using System.Xml.Linq;

namespace CSharpOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question01

            // Q1  Overloading, Overriding, and Binding
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Asnwer:
            // Method Overloading is a feature that allows a class to have multiple methods with the same name but different parameters (different type, number, or order of parameters). It is resolved at compile time (static binding).
            // Method Overriding, on the other hand, occurs when a subclass provides a specific implementation of a method that is already defined in its superclass. It is resolved at runtime (dynamic binding).

            // b)  What is the difference between Static Binding and Dynamic Binding?
            // Asnwer:
            // Static Binding is the process of resolving a method call at compile time, based on the type of the reference variable.
            // Dynamic Binding is the process of resolving a method call at runtime, based on the actual type of the object.

            #endregion

            #region Question02
            // Q2  Sealed Classes and Methods
            // a)  What is the purpose of the sealed keyword when applied to a class?
            // Answer: The purpose of the sealed keyword when applied to a class is to prevent the class from being inherited by other classes.

            // b)  What is the difference between a sealed class and a sealed method?
            // Answer: A sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in a derived class.

            // c)  Can a sealed method be overridden? Why?
            // Answer: No, a sealed method cannot be overridden because the sealed keyword prevents any further overriding of that method in derived classes.

            #endregion
            #endregion

            #region Part 02 — Practical
            // a. Create a Driver.
            Driver driver = new Driver("Ahmed Mohamed");
            // b.Create a DeliveryCenter.
            DeliveryCenter deliveryCenter = new DeliveryCenter("Main Office");
            // c.Assign the Driver to the DeliveryCenter.
            deliveryCenter.Driver = driver;

            // d.Create one StandardShipment.
            StandardShipment standardShipment = new StandardShipment( "SH001", "Laptop", 3m, 80m, new DeliveryAddress("Cairo", "Street 1", 10));
            // e.Create one ExpressShipment.
            ExpressShipment expressShipment = new ExpressShipment( "SH002", "Mobile Phone", 2m, 60m, new DeliveryAddress("Giza", "Street 2", 11), 30m);
            // f.Create one InternationalShipment.
            InternationalShipment internationalShipment = new InternationalShipment( "SH003", "Television", 8m, 120m, new DeliveryAddress("Alexandria", "Street 3", 12), "Germany", 100m );

            // g.Add all shipments to the DeliveryCenter.
            deliveryCenter.AddShipment(standardShipment); 
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Driver : {deliveryCenter.Driver.Name}");
            Console.WriteLine("------------------------------------------");
            deliveryCenter.PrintAllShipments();

            // DeliveryHelper 
            // i. Call DeliveryHelper.PrintShipmentDetails()
            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            Console.WriteLine("Standard Shipment Printed Successfully.");
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            Console.WriteLine("Express Shipment Printed Successfully.");
            DeliveryHelper.PrintShipmentDetails(internationalShipment);
            Console.WriteLine("International Shipment Printed Successfully.");
            //  Update Weight 
            // j. Demonstrate both versions of UpdateWeight()
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight..."); 
            Console.WriteLine();
            Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");
            // Version 1:
            // UpdateWeight(weight);
            Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");
            // Version 2:
            //UpdateWeight(weight, extraPackingWeight)
            standardShipment.UpdateWeight(5m, 0.5m);
            Console.WriteLine( $"Updated Weight After Packing : {standardShipment.Weight} KG" );
           
            
            Console.WriteLine();
           Console.WriteLine("==========================================");
           Console.WriteLine("Printing Using Shipment[]...");
           Console.WriteLine();
           Shipment[] shipments = { standardShipment, expressShipment, internationalShipment };
           foreach (Shipment shipment in shipments) 
            { 
                shipment.PrintShipment();
                Console.WriteLine();
            }
  
            CompletedShipment completedShipment = new CompletedShipment( "SH004", "Keyboard", 1m, 50m, new DeliveryAddress() );

            PriorityInternationalShipment priorityShipment = new PriorityInternationalShipment( "SH005", "Camera", 5m, 100m, new DeliveryAddress(), "France", 80m ); 
            priorityShipment.GenerateCustomsReport(); 

            Console.WriteLine();
            Console.WriteLine("==========================================");
            #endregion
        }
    }
}
