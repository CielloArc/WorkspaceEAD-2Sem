using Exercicio03.Persistence;
using Exercicio03.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Exercicio03.Units
{
    public class UnitOfWork : IDisposable
    {
        private CinemaContext _context = new CinemaContext();
        private IFilmeRepository _filmeRepository;

        public IFilmeRepository FilmeRepository
        {
            get
            {
                if (_filmeRepository == null)
                {
                    _filmeRepository = new FilmeRepository(_context);
                }
                return _filmeRepository;
            }
        }
        


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }

        }

    }
}