using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface INhanVien
    {
        bool Create_NV(NhanVien nv);
        NhanVien GetNV_byID(string MaNV);
        bool Update_NV(NhanVien nv);
        bool Delete_NV(string MaNV);
    }
}
