using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class AuroraCategoria : BaseCategoria
    {
        public AuroraCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Aurora";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Distinct().Count() == 5)
                return 50;
            else
                return 0;
        }
    }
}
