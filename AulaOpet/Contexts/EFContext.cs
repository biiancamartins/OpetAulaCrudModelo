using Bianca162a.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

        public class EFContext : DbContext

    {
        public EFContext() : base("Asp_Net_MVC_CS") { }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
    

