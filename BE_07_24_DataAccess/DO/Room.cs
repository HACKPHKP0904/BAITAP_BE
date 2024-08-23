using BE_07_24_DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO
{
    /*
     * Room đại diện thông tin phòng khách sạn
     */
    public class Room : IRoomInfo,IRoomAvailibility
    {
        // số phòng
        public int RoomNumber {  get; private set; }   
        // loại phòng
        public string RoomType { get;  set; }
        // trạng thái
        public bool IsAvailable { get; set; }
        public Room(int roomNumber, string roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsAvailable = true; // phòng khởi tạo là trống
        }
        public bool CheckAvailable()
        {
            return IsAvailable;
        }
        public void SetAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }
        
    }
}
