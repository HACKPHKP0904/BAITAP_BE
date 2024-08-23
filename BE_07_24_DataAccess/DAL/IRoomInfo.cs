using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DAL
{
    // tạo interface thông tin phòng chung 
    public interface IRoomInfo
    {
        int RoomNumber { get; }
        string RoomType { get; }
        bool IsAvailable { get; }
    }
}
