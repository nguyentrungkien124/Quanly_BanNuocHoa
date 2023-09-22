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
    public class BLL_TheLoai:ITheLoai_BLL
    {
        private ITheLoai _res;
        public BLL_TheLoai(ITheLoai res)
        {
            _res = res;
        }
        public TheLoai GetTL_byID(string id)
        {
            return _res.GetTL_byID(id);
        }
        public bool Create_TL(TheLoai model)
        {
            return _res.Create_TL(model);
        }
        public bool Delete_TL(string MaLoai)
        {
            return _res.Delete_TL(MaLoai);
        }
        public bool Update_TL(TheLoai model)
        {
            return (_res.Update_TL(model));
        }
    }
}
