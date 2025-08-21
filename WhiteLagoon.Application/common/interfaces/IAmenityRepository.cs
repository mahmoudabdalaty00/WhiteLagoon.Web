﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.common.interfaces
{
    public interface IAmenityRepository : IRepository<Amenity>
    {
        void Update(Amenity amenity);
    }
}
