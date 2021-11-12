using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PruebaIn
{
    public partial class BDPrueba : DbContext
    {
        public BDPrueba()
            : base("name=BDPrueba")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
