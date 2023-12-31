﻿using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_NhanVien:INhanVien
    {
        private IDatabaseHelper _dbHelper;
        public DAL_NhanVien(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public NhanVien GetNV_byID(string MaNV)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_searchNV_by_MaNV",
                     "@MaNV", MaNV);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhanVien>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create_NV(NhanVien nv)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhanvien_create",
                "@MaNV", nv.MaNV,
                "@TenNV", nv.TenNV,
                "@DiaChi", nv.DiaChi,
                "@Dienthoai", nv.DienThoai,
                "@ngaysinh", nv.NgaySinh);
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
        public bool Update_NV(NhanVien nv)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhanvien_update",
                "@MaNV", nv.MaNV,
                "@TenNV", nv.TenNV,
                "@DiaChi", nv.DiaChi,
                "@Dienthoai", nv.DienThoai,
                "@ngaysinh", nv.NgaySinh);
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
        public bool Delete_NV(string MaNV)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_DeleteNV",
                     "@MaNV", MaNV);
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
