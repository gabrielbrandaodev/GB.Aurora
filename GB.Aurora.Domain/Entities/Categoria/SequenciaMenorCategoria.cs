using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class SequenciaMenorCategoria : BaseCategoria
    {
        public SequenciaMenorCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Sequência Menor";
        }

        public override int CalcularPontuacao()
        {
            _valores = _valores.OrderBy(x => x).ToList();

            var dadosOrdemNumerica = 0;

            for (int i = 0; i < _valores.Count - 1; i++)
            {
                if (_valores[i] == (_valores[i + 1] - 1))
                    dadosOrdemNumerica++;
            }

            if (dadosOrdemNumerica > 2)
                return 15;

            return 0;
        }
    }
}
