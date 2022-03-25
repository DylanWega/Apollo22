using System;

namespace HotelTesting
{
    internal class clsRoom
    {
        public clsRoom()
        {
        }

        public string Availability { get; internal set; }
        public string Type { get; internal set; }
        public int RoomNo { get; internal set; }
        public decimal Price { get; internal set; }
        public string Description { get; internal set; }

       
    }
}