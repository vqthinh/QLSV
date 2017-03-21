using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly ITaiKhoanService _taiKhoanService;
        public TaiKhoanController()
        {
                _taiKhoanService = new TaiKhoanService();
        }
        // GET: TaiKhoan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TaiKhoan taiKhoan)
        {
            var taiKhoanDangNhap = _taiKhoanService.DangNhap(taiKhoan);
            if (taiKhoanDangNhap!=null)
            {
                FormsAuthentication.SetAuthCookie(taiKhoan.TenDangNhap, true);
                var thongTin = _taiKhoanService.ThongTinDangNhap(taiKhoanDangNhap);
                var stringThongTin = JsonConvert.SerializeObject(thongTin);
                return RedirectToAction("Index", "SinhVien",new {Area="Admin"});
            }
            TempData["Error"] = "Đăng nhập không thành công.";
            return View();
        }
    }
}