using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface ITheLoai
    {
        bool Create_TL(TheLoai nv);
        TheLoai GetTL_byID(string MaNV);
        bool Update_TL(TheLoai nv);
        bool Delete_TL(string MaNV);
    }
}
