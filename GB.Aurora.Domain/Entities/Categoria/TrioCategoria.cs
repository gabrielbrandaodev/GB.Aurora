using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class TrioCategoria : BaseCategoria
    {
        public TrioCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Trio";
        }

        public override int CalcularPontuacao()
        {
            for (int i = 1; i < 7; i++)
            {
                var dadosDeMesmoValor = _valores.Where(x => x == i);

                if (dadosDeMesmoValor.Count() > 2)
                    return dadosDeMesmoValor.Sum();
            }

            return 0;
        }
    }
}
