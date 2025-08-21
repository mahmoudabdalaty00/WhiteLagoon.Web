using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.common.interfaces
{
    public interface IVillaRepository :IRepository<Villa>
    {      
        void Update(Villa villa);
    } 
}
