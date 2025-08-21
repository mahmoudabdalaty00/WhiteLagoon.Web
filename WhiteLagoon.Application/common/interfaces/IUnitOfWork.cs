using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Application.common.interfaces
{
    public interface IUnitOfWork
    {
        public IVillaRepository VillaRepository { get;   }
        public IAmenityRepository AmenityRepository { get;  }
        void SaveChanges();
    }
}
