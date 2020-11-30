using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
