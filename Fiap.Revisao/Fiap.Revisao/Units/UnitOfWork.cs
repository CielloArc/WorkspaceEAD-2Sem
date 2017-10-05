using Fiap.Revisao.Persistence;
using Fiap.Revisao.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Units
{
    public class UnitOfWork : IDisposable
    {
        private LojaContext _context = new LojaContext();
        private IClienteRepository _clienteRepository;
        private IPedidoRepository _pedidoRepository;


        public IClienteRepository ClienteRepository
        {
            get
            {
                if (_clienteRepository == null)
                {
                    _clienteRepository = new ClienteRepository(_context);
                }

                return _clienteRepository;
            }
        }

        public IPedidoRepository PedidoRepository
        {
            get
            {
                if (_pedidoRepository == null)
                {
                    _pedidoRepository = new PedidoRepository(_context);
                }
                return _pedidoRepository;
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