using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Refuge.DAL.Entities;

namespace Refuge.BLL.Interfaces.Repositories
{
    public interface ICatRepository
    {
        // Expression permet de dire que l'on doit passer obligatoirement en param une function sans accolades { } = une func en 1! ligne
        List<Cat> FindWhere(Expression<Func<Cat, bool>> predicate);
        Cat? FindOne(params object[] ids);
        Cat Add(Cat cat);
        Cat Update(Cat cat);
        Cat Remove(Cat cat);
    }
}
