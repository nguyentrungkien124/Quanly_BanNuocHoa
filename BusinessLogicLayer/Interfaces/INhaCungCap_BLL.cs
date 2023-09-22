using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public partial interface INhaCungCap_BLL
    {
        bool Create_NCC(NhaCungCap ncc);
        NhaCungCap GetNCC_byID(string MaNCC);
        bool Update_NCC(NhaCungCap ncc);
        bool Delete_NCC(string MaNCC);
    }
}
