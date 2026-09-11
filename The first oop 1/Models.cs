using System;
using System.Collections.Generic;
using System.Text;
using The_first_oop_1;

namespace The_first_oop_1
{
    public struct DeliveryAddress
    {

        //1  DeliveryAddress struct


        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string City, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{city}, {street}, {BuildingNumber}";

        }
    }
}