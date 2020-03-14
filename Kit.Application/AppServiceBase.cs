using Kit.Application.Interfaces;
using Kit.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Kit.Application
{
    public class AppServiceBase<GenericEntity> : IDisposable, IAppServiceBase<GenericEntity> where GenericEntity : class
    {
        private readonly IRepositoryBase<GenericEntity> _repository;

        public AppServiceBase(IRepositoryBase<GenericEntity> repository)
        {
            _repository = repository;
        }

        public void Adicionar(GenericEntity entity)
        {
            _repository.Adicionar(entity);
        }

        public void Alterar(GenericEntity entity)
        {
            _repository.Alterar(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<GenericEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public GenericEntity GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public void Remover(GenericEntity entity)
        {
            _repository.Remover(entity);
        }
    }
}
