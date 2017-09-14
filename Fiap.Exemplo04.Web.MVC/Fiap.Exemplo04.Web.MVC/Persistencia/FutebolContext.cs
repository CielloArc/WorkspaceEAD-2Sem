using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Fiap.Exemplo04.Web.MVC.Models;

namespace Fiap.Exemplo04.Web.MVC.Persistencia
{
    public class FutebolContext: DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }

    }
}