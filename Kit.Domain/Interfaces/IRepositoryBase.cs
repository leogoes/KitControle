﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kit.Domain.Interfaces
{
    public interface IRepositoryBase<GenericEntity> where GenericEntity : class
    {
        void Adicionar(GenericEntity entity);
        void Remover(GenericEntity entity);
        void Alterar(GenericEntity entity);
        IEnumerable<GenericEntity> GetAll();
        GenericEntity GetById(int Id);
        void Dispose();
    }
}
