using BE_07_24_DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DAL
{
    public interface IRoomRepository
    {
        Room GetRoom(int roomNumber);
        void UpdateRoom(Room room);
    }
}
