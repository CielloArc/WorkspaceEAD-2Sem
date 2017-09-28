using Fiap.Exemplo04.Web.MVC.Persistencia;
using Fiap.Exemplo04.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Units
{
    public class UnitOfWork: IDisposable
    {
        private FutebolContext _context = new FutebolContext();
        private ITimeRepository _timeRepository;
        private IJogadorRepository _jogadorRepository;


        public ITimeRepository TimeRepository
        {
            get
            {
                if (_timeRepository == null)
                {
                    _timeRepository = new TimeRepository(_context);
                }
                return _timeRepository;
            }
        }

        public IJogadorRepository JogadorRepository
        {
            get
            {
                if (_jogadorRepository == null)
                {
                    _jogadorRepository = new JogadorRepository(_context);
                }

                return _jogadorRepository;
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