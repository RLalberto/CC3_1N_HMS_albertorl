    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemCC4
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public RoomStyle Style { get; set; }
        public bool Status { get; set; }
        public decimal BookingPrice { get; set; }
        public int V1 { get; }
        public RoomStyle QueenRoom { get; }
        public int V2 { get; }

        public HotelRoom(int roomNumber, RoomStyle style, bool status, decimal price)
        {
            RoomNumber = roomNumber;
            Style = style;
            Status = status;
            BookingPrice = price;
        }

        public HotelRoom(int v1, RoomStyle queenRoom, int v2)
        {
            V1 = v1;
            QueenRoom = queenRoom;
            V2 = v2;
        }

        public virtual string DisplayDetails()
        {
            return $"{RoomNumber} {Status} {BookingPrice}";
        }
    }
}   
