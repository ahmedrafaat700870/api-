using Microsoft.EntityFrameworkCore.Metadata;
using RepositoriesPatternWithUnitOfWork.EF.Models;
using RepositoriesPatternWithUnitOfWork.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ReporsitriesPatternWithUnitOfWork.Core.Repositories
{
    public class ClsRepositories<T> : IRepositories<T> where T : class
    {
        private readonly ApplicationDbContext _Context;

        public ClsRepositories(ApplicationDbContext context)
        {
            _Context = context;
        }

        public T GetById(int id)
        {
            try
            {
                var data = _Context.Set<T>().Find(id);
                if (data is not null)
                    return data;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                var data = _Context.Set<T>().ToList();
                if (data is not null)
                    return data;
                else
                    return new List<T>();
            }
            catch
            {
                return null;
            }


        }
        public T Edit(T entity)
        {

            try
            {
                _Context.Set<T>().Add(entity);
                _Context.SaveChanges();
                return entity;
            }
            catch
            {
                return null;
            }

        }
        public T Delete(T entity)
        {
            try
            {
                _Context.Set<T>().Remove(entity);
                _Context.SaveChanges();
                return entity;
            }
            catch
            {
                return null;
            }
        }
        public T Update(T entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Modified;
                _Context.SaveChanges();
                return entity;
            }
            catch
            {
                return null;
            }

        }

        public T GetByName(Expression<Func<T, bool>> match)
        {
            try
            {
                var data = _Context.Set<T>().SingleOrDefault(match);
                if (data is null)
                    return null;
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
