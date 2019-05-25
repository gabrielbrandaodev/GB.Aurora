using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class FullHouseCategoria : BaseCategoria
    {
        public FullHouseCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "FullHouse";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.GroupBy(x => x).Where(g => g.Count() == 2).Count() == 1
                && _valores.GroupBy(x => x).Where(g => g.Count() == 3).Count() == 1)
            {
                return _valores.Sum();
            }
            else
                return 0;
        }
    }
}
