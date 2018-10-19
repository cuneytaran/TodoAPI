using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.DataAccess.EntityFramework;
using Todo.DataAccess.Abstract;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.Concrete
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, TodoContext>, ICompanyDal
    {
    }
}
