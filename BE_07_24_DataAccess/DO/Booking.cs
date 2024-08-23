using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO
{
    /*
     * Booking quản lý thông tin đặt phòng
     */
    public class Booking
    {
        // mã đặt phòng
        public int BookingId {  get; set; }
        
        // tên khách đặt
        public string CustomerName { get; set; }   
        
        // Mã phòng đặt
        public int RoomNumber { get; set; }

        // thời gian ở 
        public DateTime CheckInDate { get; set; }

        // thời gian rời đi
        public DateTime CheckOutDate { get; set; }

    }
}
