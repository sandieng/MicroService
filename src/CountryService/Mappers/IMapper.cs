using System.Collections.Generic;

namespace CountryService.Mappers
{
    public interface IMapper<T, in TQ, out TP>
    {
        T MapFromRequest(TQ request);
        TP MapToResponse(T entity);
        IEnumerable<TP> MapToResponse(IEnumerable<T> entities);
    }
}
