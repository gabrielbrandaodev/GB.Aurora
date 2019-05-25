using System;
using System.Collections.Generic;

namespace GB.Aurora.Domain.Entities.Categoria
{
    public class BaseCategoria
    {
        protected IList<int> _valores;

        public BaseCategoria(IList<int> valores) 
            => _valores = valores;

        public string Descricao { get; set; }

        public virtual int CalcularPontuacao()
        {
            throw new NotImplementedException();
        }
    }
}
