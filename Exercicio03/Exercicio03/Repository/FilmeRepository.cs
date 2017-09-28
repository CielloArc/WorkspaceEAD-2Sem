using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercicio03.Models;
using Exercicio03.Persistence;
using System.Data.Entity;

namespace Exercicio03.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private CinemaContext _context;

        public FilmeRepository(CinemaContext context)
        {
            _context = context;
        }

        public void Alterar(Filme filme)
        {
            _context.Entry(filme).State = EntityState.Modified;
        }

        public void Cadastrar(Filme filme)
        {
            _context.Filmes.Add(filme);
        }

        public List<Filme> Listar()
        {
            return _context.Filmes.Include("Produtora").ToList();
        }

        public void Remover(int codigo)
        {
            Filme filme = _context.Filmes.Find(codigo);
            _context.Filmes.Remove(filme);
        }
    }
}