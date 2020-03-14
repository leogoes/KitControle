using Escola.Infrastructure.Repository;
using Kit.Domain.Interfaces;
using Kit.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kit.Infrastructure.Repository
{
    public class RepositoryBase<GenericEntity> : IDisposable, IRepositoryBase<GenericEntity> where GenericEntity : class
    {

        public void Adicionar(GenericEntity entity)
        {
            try
            {
                using (var ctx = new KitControleContext())
                {
                    ctx.Set<GenericEntity>().Add(entity);
                    ctx.SaveChanges();
                }

            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }
        }

        public void Remover(GenericEntity entity)
        {
            try
            {
                using (var ctx = new KitControleContext())
                {
                    ctx.Set<GenericEntity>().Remove(entity);
                    ctx.SaveChanges();
                }

            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }
        }
        public void Alterar(GenericEntity entity)
        {
            try
            {
                using (var ctx = new KitControleContext())
                {
                    ctx.Entry(entity).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }

        }

        public IEnumerable<GenericEntity> GetAll()
        {
            try
            {
                using (var ctx = new KitControleContext())
                {
                    return ctx.Set<GenericEntity>().ToList();
                }

            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }

        }

        public GenericEntity GetById(int Id)
        {
            try
            {
                using (var ctx = new KitControleContext())
                {
                    return ctx.Set<GenericEntity>().Find(Id);
                }
            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
