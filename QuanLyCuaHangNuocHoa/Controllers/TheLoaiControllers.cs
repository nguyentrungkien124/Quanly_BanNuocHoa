using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyCuaHangVemouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaiControllers : Controller
    {
        private ITheLoai_BLL _TheLoaiBLL;
        public TheLoaiControllers(ITheLoai_BLL TheLoaiBLL)
        {
            _TheLoaiBLL = TheLoaiBLL;
        }
        [Route("get-byid/{id}")]
        [HttpGet]
        public TheLoai GetTLbyID(string id)
        {
            return _TheLoaiBLL.GetTL_byID(id);
        }
        [Route("create-theloai")]
        [HttpPost]
        public TheLoai CreateTL([FromBody] TheLoai tl)
        {
            _TheLoaiBLL.Create_TL(tl);
            return tl;
        }
        [Route("update_theloai")]
        [HttpPut]
        public TheLoai Update_TL([FromBody] TheLoai tl)
        {
            _TheLoaiBLL.Update_TL(tl);
            return tl;
        }
        [Route("delete_theloai")]
        [HttpDelete]
        public IActionResult Delete_TL([FromBody] string maloai)
        {
            _TheLoaiBLL.Delete_TL(maloai);
            return Ok();
        }
    }
}
