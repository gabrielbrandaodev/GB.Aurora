using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class TresCategoria : BaseCategoria
    {
        public TresCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Três";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 3))
                return _valores.Where(x => x == 3).Sum();
            else
                return 0;
        }
    }
}
