using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace selectlist.Models {
    public class UserModel {
        public string UserName { get; set; }
        public string Country { get; set; }
        public IEnumerable<SelectListItem> Countries { get; init; }
    }
}