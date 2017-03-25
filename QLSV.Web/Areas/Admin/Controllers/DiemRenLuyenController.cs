using System.Web.Mvc;

namespace QLSV.Web.Areas.Admin.Controllers
{
    public class DiemRenLuyenController : Controller
    {
        // GET: Admin/DiemRenLuyen
        public ActionResult Index()
        {
            ViewBag.Menu = "Quản Lý Điểm rèn luyện";
            return View();
        }
    }
}