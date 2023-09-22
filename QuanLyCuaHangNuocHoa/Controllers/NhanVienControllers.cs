using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyCuaHangVemouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienControllers : ControllerBase
    {
            private INhanVien_BLL _NhanVienBLL;
            public NhanVienControllers(INhanVien_BLL NhanVienBLL)
            {
                _NhanVienBLL = NhanVienBLL;
            }
            [Route("get-byid/{id}")]
            [HttpGet]
            public NhanVien GetNVbyID(string id)
            {
                return _NhanVienBLL.GetNV_byID(id);
            }
            [Route("create-nhanvien")]
            [HttpPost]
            public NhanVien CreateNV([FromBody] NhanVien nv)
            {
                _NhanVienBLL.Create_NV(nv);
                return nv;
            }
            [Route("update_nhanvien")]
            [HttpPut]
            public NhanVien Update_NV([FromBody] NhanVien nv)
            {
                _NhanVienBLL.Update_NV(nv);
                return nv;
            }
            [Route("delete_nhanvien")]
            [HttpDelete]
            public IActionResult Delete_NV([FromBody] string manv)
            {
                _NhanVienBLL.Delete_NV(manv);
                return Ok();
            }
    }
}
