﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Web.ModelVM
{
    public class AmenityVM
    {
      public Amenity? amenity {  get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> villaList { get; set; }
    }
}
