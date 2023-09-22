using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyCuaHangVemouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangControllers : ControllerBase
    {
        private IKhachHang_BLL _KhachHangBLL;
        public KhachHangControllers(IKhachHang_BLL KhachHangBLL)
        {
            _KhachHangBLL = KhachHangBLL;
        }
        [Route("get_byid/{id}")]
        [HttpGet]
        public KhachHang GetKH_byID(string id)
        {
            return _KhachHangBLL.GetKH_ByID(id);
        }
        [Route("create_khachhang")]
        [HttpPost]
        public KhachHang CreateKH([FromBody] KhachHang kh)
        {
            _KhachHangBLL.Create_KH(kh);
            return kh;
        }
        [Route("update_khachhang")]
        [HttpPut]
        public KhachHang Update_KH([FromBody] KhachHang kh)
        {
            _KhachHangBLL.Update_KH(kh);
            return kh;
        }
        [Route("delete_khachhang")]
        [HttpDelete]
        public IActionResult Delete_KH([FromBody] string MaKH)
        {
            _KhachHangBLL.Delete_KH(MaKH);
            return Ok();
        }
    }
}
