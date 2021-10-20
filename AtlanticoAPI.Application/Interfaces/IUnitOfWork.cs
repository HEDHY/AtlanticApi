using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        bool HasUnsavedChanges();
    }
}
