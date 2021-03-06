﻿using System;
using System.Web.Mvc;

namespace QLSV.Web.Models
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(
                            AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                string loginUrl = "~/TaiKhoan/DangNhap"; // Default Login Url 
                filterContext.Result = new RedirectResult(loginUrl);
            }
        }
    }
}