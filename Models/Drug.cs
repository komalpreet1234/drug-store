﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStoreManagement.Models
{
    public class Drug
    {
        public Drug()
        {
            DrugName = "";

        }

        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }

        [Key]
        public int DrugCode { get; set; }

        public string DrugName { get; set; }

        public string Category { get; set; }

        public string DrugCompany { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public IdentityUser AddedBy { get; set; }
    }
}
