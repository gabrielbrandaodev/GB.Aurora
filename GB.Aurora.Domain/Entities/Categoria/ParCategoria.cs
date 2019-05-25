using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class ParCategoria : BaseCategoria
    {
        public ParCategoria(IList<int> valores)
            : base(valores)
        {
            Descricao = "Par";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Distinct().Count() < 5)
                return _valores.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .FirstOrDefault()
                            .Sum();
            else
                return 0;
        }
    }
}
