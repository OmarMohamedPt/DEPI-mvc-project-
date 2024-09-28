using BLL.Interface;
using DAL.Data.DbContext;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class Repositorie : Interface1
    {
        private readonly AppDbContext _appDbContext;
        public Repositorie(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public int Add(Product product)
        {
            _appDbContext.Products.Add(product);
            return _appDbContext.SaveChanges();
        }

        public int Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
