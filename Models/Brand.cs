using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStoreManagement.Models
{
    public class Brand
    {
        public Brand()
        {
            BrandName = "";
        }

        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public string Details { get; set; }
        public List<Drug> DrugList { get; set; }
    }
}
