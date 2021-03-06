﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class LopHocPhanApiController : ApiController
    {
        private readonly ILopHocPhanService _lopHocPhanService;
        public LopHocPhanApiController()
        {
            _lopHocPhanService = new LopHocPhanService();
        }

        [HttpGet]
        public HttpResponseMessage GetMonHoc(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_lopHocPhanService.GetMonHocs(), loadOptions);
            return Request.CreateResponse(obj);
        }


        [HttpPost]
        public HttpResponseMessage PostMonHoc(FormDataCollection form)
        {
            var values = form.Get("values");

            var monHoc = new MonHoc();
            JsonConvert.PopulateObject(values, monHoc);

            if (_lopHocPhanService.AddMonHoc(monHoc))
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Mã môn học đã tồn tại");
        }

        [HttpGet]
        public HttpResponseMessage GetHocKies(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_lopHocPhanService.GetHocKies(), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_lopHocPhanService.Where(x=>x.Deleted==false), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var lopHp = new LopHocPhan();
            JsonConvert.PopulateObject(values, lopHp);

            if (_lopHocPhanService.Add(lopHp))
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Mã môn học đã tồn tại");
        }

        [HttpDelete]
        public void Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            _lopHocPhanService.Delete(key);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var lopHp = _lopHocPhanService.GetById(key);
            JsonConvert.PopulateObject(values, lopHp);


            if (_lopHocPhanService.Update(lopHp))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }
    }
}
