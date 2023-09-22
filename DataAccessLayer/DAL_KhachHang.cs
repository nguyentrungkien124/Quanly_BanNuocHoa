using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataModel;

namespace DataAccessLayer
{
    public class DAL_KhachHang:IKhachHang
    {
        private IDatabaseHelper _dbHelper;
        public DAL_KhachHang(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Create(KhachHang KH)
        {
            throw new NotImplementedException();
        }

        public KhachHang GetKH_ByID(string MaKH)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_searchKH_by_MaKH",
                     "@MaKH", MaKH);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHang>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create_KH(KhachHang KH)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_khachhang_create",
                "@MaKH", KH.MaKH,
                "@TenKH", KH.TenKH,
                "@MaSoThe", KH.MaSoThe,
                "@GioiTinh", KH.GioiTinh,
                "@NgaySinh", KH.NgaySinh,
                "@Diachi", KH.DiaChi,
                "@Email", KH.Email,
                "@SDT" , KH.SDT) ;
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update_KH(KhachHang KH)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_khachhang_update",
                "@MaKH", KH.MaKH,
                "@TenKH", KH.TenKH,
                "@MaSoThe", KH.MaSoThe,
                "@GioiTinh", KH.GioiTinh,
                "@NgaySinh", KH.NgaySinh,
                "@Diachi", KH.DiaChi,
                "@Email", KH.Email,
                "@SDT", KH.SDT);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete_KH(string MaKH)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_DeleteKH",
                     "@MaKH", MaKH);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
