using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcf_19Aralik2017DMOLibrary;

namespace WebClient.Models.Views
{
    public class ProductModel
    {
        public List<ProductDTO> plist { get; set; }
        public ProductDTO pDto { get; set; }
    }
}