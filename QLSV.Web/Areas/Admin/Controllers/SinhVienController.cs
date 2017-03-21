using System.Web.Mvc;
using QLSV.Entities.Models;
using QLSV.Services.Services;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class SinhVienController : Controller
    {
        private readonly SinhVienService _sinhVienService;

        public SinhVienController()
        {
            _sinhVienService = new SinhVienService();
        }
        // GET: Admin/SinhVien
        public ActionResult Index()
        {
            var list = _sinhVienService.GetAll();
            return View();
        }

        public JsonResult GetList(JQueryDataTableParamModel param)
        {
            var list = _sinhVienService.GetListSinhViens(param.sSearch, param.iDisplayStart / param.iDisplayLength, param.iDisplayLength);
            //var page = param.iDisplayStart / param.iDisplayLength;
            //var size = list.Count;
            //var search = param.sSearch ?? String.Empty;
            //Response.Cookies.Append("page", page.ToString());
            //Response.Cookies.Append("size", size.ToString());
            //Response.Cookies.Append("search", search);

            return Json(new DataTableResult()
            {
                data = list,
                draw = param.sEcho,
                recordsFiltered = _sinhVienService.Total(),
                recordsTotal = list.Count
            },JsonRequestBehavior.AllowGet);
        }
    }
}