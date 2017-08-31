using Fiap.Exemplo03.Web.MVC.Models;
using System.Data.Entity;
using System;

namespace Fiap.Exemplo03.Web.MVC
{
    public class LoteriaContext : DbContext
    {
        public DbSet<Apostador> Apostadores { get; set; }
        public DbSet<Aposta> Apostas { get; set; }       
    }
}