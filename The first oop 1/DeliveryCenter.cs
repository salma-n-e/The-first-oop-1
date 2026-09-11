using System;
using System.Collections.Generic;
using System.Text;

namespace The_first_oop_1
{
    public struct DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;


        public DeliveryCenter()
        {
            shipments = new Shipment[10];
            count = 0;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    return default;
                }
                return shipments[index];
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                    return default;

                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].trackingCode == trackingCode)
                    {
                        return shipments[i];

                    }
                }
                return default;
            }
        }
        // Method 
        public bool AddShipment(Shipment shipment)
        {
            if (count < 10)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }
            return false;

        }
    }
}