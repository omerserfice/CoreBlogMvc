using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreBlogMvc.Models
{
    public class ViewModel
    {
        
            public string Sehir { get; set; }
            public IList<SelectListItem> Sehirler { get; set; }

        
    }
}
