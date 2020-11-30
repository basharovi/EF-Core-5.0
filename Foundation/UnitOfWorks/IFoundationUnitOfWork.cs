using DataAccessLayer;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfworks
{
    public interface IFoundationUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
    }
}
