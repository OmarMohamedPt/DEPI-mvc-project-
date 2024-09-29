using BLL.Interface;
using DAL.Data.DbContext;
using DAL.Models.Product;

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
            _appDbContext.Products.Remove(product);
            return _appDbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _appDbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _appDbContext.Find<Product>(id);
        }

        public int Update(Product product)
        {
            _appDbContext.Products.Update(product);
            return _appDbContext.SaveChanges();
        }

        Product Get(int id)
        {
            var product = _appDbContext.Products.Local.Where(p => p.id == id).FirstOrDefault();
            if (product is null)
                product = _appDbContext.Products.Where(p => p.id == id).FirstOrDefault();
            return product;

        }

        

       

    }
}
