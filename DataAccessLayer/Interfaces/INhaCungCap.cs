﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface INhaCungCap
    {
        bool Create_NCC(NhaCungCap ncc);
        NhaCungCap GetNCC_byID(string MaNCC);
        bool Update_NCC(NhaCungCap ncc);
        bool Delete_NCC(string MaNCC);
    }
}
