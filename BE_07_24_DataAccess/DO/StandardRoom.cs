using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO
{
    // loại phòng thường
    public class StandardRoom : Room
    {
        public StandardRoom(int roomNumber) : base(roomNumber,"Phòng thường")
        {

        }
    }
}
