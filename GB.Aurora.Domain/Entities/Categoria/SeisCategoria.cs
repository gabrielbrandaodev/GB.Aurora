using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class SeisCategoria : BaseCategoria
    {
        public SeisCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Seis";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 6))
                return _valores.Where(x => x == 6).Sum();
            else
                return 0;
        }
    }
}
