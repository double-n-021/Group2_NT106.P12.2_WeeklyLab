using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Lab03
{
    internal class Manage
    {
        public List<Seat> Seats { get; set; }  // Danh sách ghế

        public Manage()
        {
            Seats = new List<Seat>();

            // Khởi tạo 25 ghế, từ 1 đến 25
            for (int i = 1; i <= 25; i++)
            {
                Seats.Add(new Seat(i));
            }
        }

        public string BookSeat(int seatNumber, string customerName)
        {
            var seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);

            if (seat == null)
            {
                return "Invalid seat number.";
            }

            if (seat.Status == "Booked")
            {
                return "Seat already booked.";
            }

            // Đặt ghế
            seat.Status = "Booked";
            seat.CustomerName = customerName;

            return "Seat booked successfully.";
        }

        public string SelectSeat(int seatNumber, string customerName)
        {
            var seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
            if (seat == null)
            {
                return "Invalid seat number.";
            }

            if (seat.Status == "Booked")
            {
                return "Seat already booked.";
            }

            seat.Status = "Selecting";
            seat.CustomerName = customerName;

            return "Seat selected. Please confirm booking.";
        }
        public string CancelSeatSelection(int seatNumber)
        {
            var seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
            if (seat == null)
            {
                return "Invalid seat number.";
            }

            if (seat.Status != "Selecting")
            {
                return "Seat is not in selecting status.";
            }

            // Hủy việc chọn ghế, trả lại trạng thái "Available"
            seat.Status = "Available";
            seat.CustomerName = null;

            return "Seat selection canceled. It is now available.";
        }

        public string GetSeatStatus(int seatNumber)
        {
            var seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
            if (seat == null)
            {
                return "Invalid seat number.";
            }

            return seat.Status;  // Trả về trạng thái của ghế (e.g. "Booked", "Selecting", hoặc "Available")
        }
    }
}
