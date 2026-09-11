using System;
using The_first_oop_1;

namespace The_first_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1 
            // a) is a struct (Value Type) Modifying the copy will not affect the original variable.
            // b) is a class (Reference Type) Modifying the object through either variable will affect both,
            // as they both point to the same instance.

            // Q2
            // a) Public Fields No Data Validation  Lack of Read-Only Protection
            // b) Encapsulation & Control  Data Validation   Controlled Access



            // 6 Main
            // a. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // b & c 
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i} Data");

                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int bNum = int.Parse(Console.ReadLine());

                //  Address (Struct)
                DeliveryAddress address = new DeliveryAddress(city, street, bNum);

              
                Shipment shipment = new Shipment(code, desc, weight, fee, address);
                center.AddShipment(shipment);

                Console.WriteLine();
            }

            // d. 
            Console.WriteLine("All Shipments (Using Integer Indexer) ");
            for (int i = 0; i < 3; i++)
            {
               
                Console.WriteLine(center[i]);
            }

            // e. 
            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            // f. 
            // g.
            Shipment foundShipment = center[searchCode]; 

            if (!foundShipment.Equals(default(Shipment)))

            {
                Console.WriteLine("Shipment Found:");
                Console.WriteLine(foundShipment);
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // h. 
            Console.WriteLine(" Demonstrating Struct Copy Behavior ");

            DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "El-Tahrir", 15);
            DeliveryAddress copiedAddress = originalAddress; 

           
            copiedAddress.city = "Alexandria";

            Console.WriteLine($"Original Address City: {originalAddress.city}"); 
            Console.WriteLine($"Copied Address City: {copiedAddress.city}");     
        }
    }
}