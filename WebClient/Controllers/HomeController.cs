using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.Models.Views;
using WebClient.ServiceDMO;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DMOServiceClient s = new DMOServiceClient();
        ProductModel m = new ProductModel();
        public ActionResult Index()
        {
            m.plist = s.GetProductsListBySupplierId(Convert.ToInt32(Session["SupplierID"])).ToList();
            return View(m);
        }
        public ActionResult TumUrunler()
        {
            m.plist = s.GetProductsList().ToList();
            return View(m);
        }
        public ActionResult Guncelle(int id)
        {
            m.pDto = s.GetOneProduct(id);
            return View(m);
        }
        [HttpPost]
        public ActionResult Guncelle(ProductModel m)
        {
            bool sonuc = s.ProductUpdate(m.pDto);
            return RedirectToAction("Index");
        }
    }
}