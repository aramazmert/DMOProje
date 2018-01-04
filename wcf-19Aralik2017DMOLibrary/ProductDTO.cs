using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace wcf_19Aralik2017DMOLibrary
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public int SupplierID { get; set; }
    }
}
