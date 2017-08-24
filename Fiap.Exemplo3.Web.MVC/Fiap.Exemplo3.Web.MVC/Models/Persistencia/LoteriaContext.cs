using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo3.Web.MVC.Models.Persistencia
{
    public class LoteriaContext : DbContext
    {
        private DbSet<Apostador> apostadores;

        public DbSet<Apostador> Apostadores
        {
            get { return apostadores; }
            set { apostadores = value; }
        }
    }
}