using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public partial interface ITheLoai_BLL
    {
        bool Create_TL(TheLoai tl);
        TheLoai GetTL_byID(string MaLoai);
        bool Update_TL(TheLoai tl);
        bool Delete_TL(string MaLoai);
    }
}
