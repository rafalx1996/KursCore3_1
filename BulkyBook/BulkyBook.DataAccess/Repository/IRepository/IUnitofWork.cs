using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitofWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_CAll { get; }
    }
}
