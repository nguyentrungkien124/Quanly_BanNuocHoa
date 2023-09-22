using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataModel;
using DataAccessLayer.Interfaces;
using BusinessLogicLayer.Interfaces;

namespace BusinessLogicLayer
{
     public class BLL_KhachHang:IKhachHang_BLL
     {
        private IKhachHang _res;
        public BLL_KhachHang(IKhachHang res)
        {
            _res = res;
        }
        public KhachHang GetKH_ByID(string id)
        {
            return _res.GetKH_ByID(id);
        }
        public bool Create_KH(KhachHang model)
        {
            return _res.Create_KH(model);
        }
        public bool Delete_KH(string MaKH)
        {
            return _res.Delete_KH(MaKH);
        }
        public bool Update_KH(KhachHang model)
        {
            return _res.Update_KH(model);
        }
    }
}
