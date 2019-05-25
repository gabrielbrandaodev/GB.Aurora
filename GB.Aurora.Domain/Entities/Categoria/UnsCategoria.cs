using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class UnsCategoria : BaseCategoria
    {
        public UnsCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Uns";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 1))
                return _valores.Where(x => x == 1).Sum();
            else
                return 0;
        }
    }
}
