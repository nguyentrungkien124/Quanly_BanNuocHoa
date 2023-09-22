using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL_NhaCungCap:INhaCungCap_BLL
    {
        private INhaCungCap _res;
        public BLL_NhaCungCap(INhaCungCap res)
        {
            _res = res;
        }
        public NhaCungCap GetNCC_byID(string id)
        {
            return _res.GetNCC_byID(id);
        }
        public bool Create_NCC(NhaCungCap model)
        {
            return _res.Create_NCC(model);
        }
        public bool Delete_NCC(string MaNCC)
        {
            return _res.Delete_NCC(MaNCC);
        }
        public bool Update_NCC(NhaCungCap model)
        {
            return (_res.Update_NCC(model));
        }
    }
}
