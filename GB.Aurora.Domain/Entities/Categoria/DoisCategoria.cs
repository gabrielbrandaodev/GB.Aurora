using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class DoisCategoria : BaseCategoria
    {
        public DoisCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Dois";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 2))
                return _valores.Where(x => x == 2).Sum();
            else
                return 0;
        }
    }
}
