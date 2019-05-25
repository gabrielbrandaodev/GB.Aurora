using System.Collections.Generic;
using System.Linq;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class DoisParesCategoria : BaseCategoria
    {
        public DoisParesCategoria(IList<int> valores)
            :base(valores)
        {
            Descricao = "Dois Pares";
        }

        public override int CalcularPontuacao()
        {
            if (_valores.Distinct().Count() > 3)
                return 0;
            else
            {
                var contadorDePares = 0;
                var somaDosPares = 0;

                for (int i = 1; i < 7; i++)
                {
                    if (_valores.Where(x => x == i).Count() > 1)
                    {
                        contadorDePares++;
                        somaDosPares = somaDosPares + (i * 2);
                    }
                }

                return somaDosPares;
            }
        }
    }
}
