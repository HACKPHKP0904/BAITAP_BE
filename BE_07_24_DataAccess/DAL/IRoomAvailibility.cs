using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DAL
{
    public interface IRoomAvailibility
    {
        // hàm kiểm tra trạng thái đặt
        bool CheckAvailable();
        // đặt tính trạng thái đặt 
        void SetAvailable(bool isAvailable);
    }
}
