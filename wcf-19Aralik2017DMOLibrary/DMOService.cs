using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DMOEntities;

namespace wcf_19Aralik2017DMOLibrary
{
    public class DMOService : IDMOService
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public ProductDTO GetOneProduct(int id)
        {
            Products p = db.Products.Find(id);
            ProductDTO pdto = new ProductDTO();
            pdto.ProductID = p.ProductID;
            pdto.ProductName = p.ProductName;
            pdto.UnitPrice = (decimal)p.UnitPrice;
            return pdto;
        }

        public List<ProductDTO> GetProductsList()
        {
            List<ProductDTO> plist = db.Products.Select(x => new ProductDTO
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                UnitPrice = (decimal)x.UnitPrice
            }).ToList();
            return plist;
        }

        public bool ProductUpdate(ProductDTO pdto)
        {
                Products p = db.Products.Find(pdto.ProductID);
                p.ProductName = pdto.ProductName;
                p.UnitPrice = pdto.UnitPrice;
                db.SaveChanges();
                return true;
        }
        public UserDTO Login(int uid, string pw)
        {
            //return db.Users.Where(x => x.UserID == uid && x.Password == pw).Select(x => new UserDTO
            //{
            //    UserID = x.UserID,
            //    SupplierID = x.SupplierID,
            //    UserRole = x.UserRole
            //}).FirstOrDefault();
            UserDTO udto = new UserDTO();
            Users u = db.Users.Where(x => x.UserID == uid && x.Password == pw).FirstOrDefault();
            udto.UserID = u.UserID;
            udto.UserRole = u.UserRole;
            udto.SupplierID = u.SupplierID;
            return udto;
        }

        public List<ProductDTO> GetProductsListBySupplierId(int suppID)
        {
            List<ProductDTO> plist = db.Products.Select(x => new ProductDTO
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                UnitPrice = (decimal)x.UnitPrice,
                SupplierID =(int) x.SupplierID
            }).Where(x => x.SupplierID == suppID).ToList();
            return plist;
        }
    }
}
