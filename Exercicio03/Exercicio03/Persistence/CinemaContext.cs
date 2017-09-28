using Exercicio03.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Exercicio03.Persistence
{
    public class CinemaContext: DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Produtora> Produtoras{ get; set; }
    }
}