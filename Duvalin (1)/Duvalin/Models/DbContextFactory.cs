using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models
{
    public class DbContextFactory
    {
        private readonly DbContextOptions _options;

        public DbContextFactory(DbContextOptions options) =>
            _options = options;

        public DataContext Create()
        {
            var res = new DataContext(_options);
            res.Database.EnsureCreated();
            return res;
        }
    }
}
