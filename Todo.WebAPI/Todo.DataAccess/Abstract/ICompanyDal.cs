using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.DataAccess;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
    }
}
