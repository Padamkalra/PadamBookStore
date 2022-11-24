using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadamBookStore.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }      //displays all the product 
        public IEnumerable<SelectListItem> CategoryList { get; set; }  //install package 'Microsoft.ASp.NEtCore.Mvc.Viewfeatures 
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

    }
}

