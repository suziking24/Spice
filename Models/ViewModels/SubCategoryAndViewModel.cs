using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Spice.Models.ViewModels
{
    public class SubCategoryAndViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }
        public  List<string> SubCategoryList { get; set; }
        public string StatusMessage { get; set; }

    }
}
