using BE_07_24_DataAccess.DAL;
using BE_07_24_DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DALImpl
{
    public class RoomRepositoryService : IRoomRepository
    {
        List<Room> rooms = new List<Room>();
        // khởi tạo nhận phòng
        public Room GetRoom(int roomnumber)
        {
            var returnData = new ReturnData();
            var existingRoom = rooms[roomnumber];
            if(existingRoom == null)
            {
                returnData.returnCode = -4;
                returnData.returnMsg = "Không tìm thấy phòng này";
            }
            return rooms.FirstOrDefault(s=>s.RoomNumber == roomnumber); 
        }
        // cập nhật phòng
        public void UpdateRoom (Room room)
        {
            var returnData = new ReturnData();
            var existingRoom = rooms.FirstOrDefault(r => r.RoomNumber == room.RoomNumber);
            if (existingRoom == null)
            {
                returnData.returnCode = -2;
                returnData.returnMsg = "Không có số phòng này";
            }
            existingRoom.RoomType = room.RoomType;
            existingRoom.IsAvailable = room.IsAvailable;

        }
    }
}
