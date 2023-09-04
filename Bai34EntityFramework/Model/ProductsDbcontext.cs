using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Bai34EntityFramework.Model
{
    public class ProductsDbcontext: DbContext
    {

        private const string connstring = "Data Source=.;Initial Catalog=TungShop;Integrated Security=false;User ID=sa;Password=12345678;MultipleActiveResultSets=true";
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
