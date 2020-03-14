using System;
using System.Collections.Generic;
using System.Text;

namespace Kit.Application.Interfaces
{
    public interface IAppServiceBase<GenericEntity> where GenericEntity : class
    {
        void Adicionar(GenericEntity entity);
        void Remover(GenericEntity entity);
        void Alterar(GenericEntity entity);
        IEnumerable<GenericEntity> GetAll();
        GenericEntity GetById(int Id);
    }
}
