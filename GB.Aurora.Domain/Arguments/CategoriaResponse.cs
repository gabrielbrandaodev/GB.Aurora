using GB.Aurora.Domain.Entities.Categoria;

namespace GB.Aurora.Domain.Arguments
{
    public class CategoriaResponse
    {
        public string Descricao { get; set; }
        public int Pontos { get; set; }

        public static explicit operator CategoriaResponse(BaseCategoria categoria)
        {
            return new CategoriaResponse()
            {
                Descricao = categoria.Descricao,
                Pontos = categoria.CalcularPontuacao()
            };
        }
    }
}