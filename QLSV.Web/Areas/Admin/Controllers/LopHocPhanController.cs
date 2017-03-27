using System.Web.Mvc;

namespace QLSV.Web.Areas.Admin.Controllers
{
    public class LopHocPhanController : Controller
    {
        // GET: Admin/LopHocPhan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MonHoc()
        {
            ViewBag.Menu = "Quản lý Môn học";
            return View();
        }
    }
}