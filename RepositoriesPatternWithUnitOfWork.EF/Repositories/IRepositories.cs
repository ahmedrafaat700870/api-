using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesPatternWithUnitOfWork.EF.Repositories
{
    public interface IRepositories <T> where T : class
    {
        T GetById(int id);
        T GetByName(Expression<Func<T , bool>> match);
        IEnumerable<T> GetAll();
        T Edit(T entity);
        T Delete(T entity);
        T Update(T entity);

    }
}
