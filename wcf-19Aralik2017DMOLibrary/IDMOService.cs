using DMOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_19Aralik2017DMOLibrary
{
    [ServiceContract]
    public interface IDMOService
    {
        [OperationContract]
        List<ProductDTO> GetProductsList();
        [OperationContract]
        ProductDTO GetOneProduct(int id);
        [OperationContract]
        bool ProductUpdate(ProductDTO pdto);
        [OperationContract]
        UserDTO Login(int id, string pass);
        [OperationContract]
        List<ProductDTO> GetProductsListBySupplierId(int suppID);
    }
}
