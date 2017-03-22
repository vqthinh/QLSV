using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
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

        [ChildActionOnly]
        public PartialViewResult _LoginInfo()
        {
            var oldCookie = HttpContext.Request.Cookies["UserInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                return PartialView(loginModel);
            }
            return PartialView();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}