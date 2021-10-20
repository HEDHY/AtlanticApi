using AtlanticoAPI.Application.Interfaces;
using AtlanticoAPI.Infrastructure.Data.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiDbContext _context;

  

        public UnitOfWork(ApiDbContext context)
        {
            this._context = context;
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        public bool HasUnsavedChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }
    }
}
