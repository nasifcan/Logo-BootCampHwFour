using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFour.DataAccess.EntityFramework.Repository.Abstracts
{
    public interface IUnitOfWork
    {
        AppDbContext Context { get; }
        void Commit();
    }
}
