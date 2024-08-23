using BE_07_24_DataAccess.DAL;
using BE_07_24_DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DALImpl
{
    public class BookingService : IBookingCreation,IBookingCancel,IBookingInfo
    {
        private readonly IRoomRepository _roomRepository;
        private readonly List<Booking> bookings = new List<Booking>();
        // khởi tạo lớp BookingService 
        public BookingService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        // tạo phòng 
        public void CreateBooking(Booking booking)
        {
            var returnData = new ReturnData();
            var room = _roomRepository.GetRoom(booking.RoomNumber);
            if(room == null || room.IsAvailable)
            {
                returnData.returnCode = -3;
                returnData.returnMsg = " Phòng không tồn tại";
            }
            bookings.Add(booking);
            room.IsAvailable = false;
            _roomRepository.UpdateRoom(room);
        }
        // hủy phòng
        public void CancelBooking(int bookingId)
        {
            var returnData = new ReturnData();
            var booking = bookings.FirstOrDefault(s => s.BookingId == bookingId);
            var room = _roomRepository.GetRoom(booking.BookingId);
            if(room == null)
            {
                returnData.returnCode = -2;
                returnData.returnMsg = "Không có phòng này";
            }    
            if(booking == null)
            {
                returnData.returnCode = -1;
                returnData.returnMsg = "Không tồn tại phòng này";
            }
            bookings.Remove(booking);
            room.IsAvailable = true;
            _roomRepository.UpdateRoom(room);   
        }
        // lấy thông tin phòng đặt
        public Booking GetBooking(int bookingId)
        {
            return bookings.FirstOrDefault(s=>s.BookingId == bookingId);    
        }
    }
}
