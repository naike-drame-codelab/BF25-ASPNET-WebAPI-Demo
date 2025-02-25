using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be.Khunly.EFRepository;
using Refuge.BLL.Interfaces.Repositories;
using Refuge.DAL.Entities;

namespace Refuge.DAL.Repositories
{
    public class CatRepository(RefugeContext ctx) : RepositoryBase<Cat>(ctx), ICatRepository
    {
    }
}
