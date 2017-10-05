using Fiap.Revisao.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.Models;
using System.Data.Entity;

namespace Fiap.Revisao.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private LojaContext _context;


        public ClienteRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public List<Cliente> Listar()
        {
            return _context.Clientes.Include("Pedidos").ToList();
        }

        public void Remover(int codigo)
        {
            Cliente cliente = _context.Clientes.Find(codigo);
            _context.Clientes.Remove(cliente);
        }
    }
}