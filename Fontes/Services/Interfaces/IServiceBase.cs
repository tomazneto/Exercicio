using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        void Inserir(T entity);
    }
}
