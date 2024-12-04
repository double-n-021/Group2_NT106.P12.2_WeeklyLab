using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Lab03
{
    internal class Seat
    {
        public int SeatNumber { get; set; }  // Tên ghế (ví dụ: "Seat 1", "Seat 2",...)
        public string Status { get; set; }  // Trạng thái ghế ("Available", "Selected", "Booked")
        public string CustomerName { get; set; }  // Tên khách hàng đã đặt ghế (nếu ghế đã được đặt)

        public Seat(int seatNumber)
        {
            SeatNumber = seatNumber;
            Status = "Available";
            CustomerName = string.Empty;
        }
    }
}
