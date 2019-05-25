using GB.Aurora.Domain.Arguments;
using GB.Aurora.Domain.Entities.Categoria;
using GB.Aurora.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Service.Aurora
{
    public class AuroraService : IAuroraService
    {
        public CalcularPontosResponse Calcular(IList<int> valores)
        {
            var response = new CalcularPontosResponse();

            response.Resultado.Add((CategoriaResponse)new UnsCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new DoisCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new TresCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new QuatrosCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new CincosCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new SeisCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new ParCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new DoisParesCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new TrioCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new QuadraCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new SequenciaMenorCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new SequenciaMaiorCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new FullHouseCategoria(valores));
            response.Resultado.Add((CategoriaResponse)new AuroraCategoria(valores));

            return response; 
        }
    }
}
