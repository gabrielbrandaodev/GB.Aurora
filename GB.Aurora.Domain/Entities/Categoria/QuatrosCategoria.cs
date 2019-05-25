using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class QuatrosCategoria : BaseCategoria
    {
        public QuatrosCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Quatros";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Any(x => x == 4))
                return _valores.Where(x => x == 4).Sum();
            else
                return 0;
        }
    }
}
