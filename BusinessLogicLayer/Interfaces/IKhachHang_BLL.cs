using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer.Interfaces
{
    public partial interface IKhachHang_BLL
    {
        bool Create_KH(KhachHang kh);
        KhachHang GetKH_ByID(string MaKH);
        bool Update_KH(KhachHang kh);
        bool Delete_KH(string MaKH);
    }
}
