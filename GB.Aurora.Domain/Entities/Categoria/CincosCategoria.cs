using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class CincosCategoria : BaseCategoria
    {
        public CincosCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Cincos";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 5))
                return _valores.Where(x => x == 5).Sum();
            else
                return 0;
        }
    }
}
