using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace selectlist.Models {
    public class UserModel {
        public string UserName { get; set; }
        public int Country { get; set; }
        public string CountryDisplayName { get; set; }
        public IEnumerable<SelectListItem> Countries { get; init; }
    }
}