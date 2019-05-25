using GB.Aurora.Domain.Arguments;
using System.Collections.Generic;

namespace GB.Aurora.Domain.Interfaces
{
    public interface IAuroraService
    {
        CalcularPontosResponse Calcular(IList<int> valores);
    }
}
