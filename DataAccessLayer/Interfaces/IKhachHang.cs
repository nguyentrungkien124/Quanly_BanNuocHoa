using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface IKhachHang
    {
        KhachHang GetKH_ByID(string MaKH);
        bool Create_KH(KhachHang KH);
        bool Update_KH(KhachHang KH);
        bool Delete_KH(string MaKH);
    }
}
