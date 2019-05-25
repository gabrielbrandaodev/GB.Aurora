using System.Collections.Generic;

namespace GB.Aurora.Domain.Arguments
{
    public class CalcularPontosResponse
    {
        public IList<CategoriaResponse> Resultado { get; set; }

        public CalcularPontosResponse()
        {
            Resultado = new List<CategoriaResponse>();
        }
    }
}
