using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wcf_19Aralik2017DMOLibrary;
using WebClient.Models.Views;
using WebClient.ServiceDMO;

namespace WebClient.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DMOServiceClient s = new DMOServiceClient();
        UserDTO u = new UserDTO();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel m)
        {
            int id = m.uDto.UserID;
            string pw = m.pw;
            u = s.Login(id, pw);
            Session["User"] = u.UserID;
            Session["Role"] = u.UserRole;
            Session["SupplierID"] = u.SupplierID;
            return RedirectToAction("Index", "Home");
        }
    }
}