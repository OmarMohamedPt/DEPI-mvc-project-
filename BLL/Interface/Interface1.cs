using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.Product;
using Product = DAL.Models.Product.Product;

namespace BLL.Interface
{
    public interface Interface1
    {
        IEnumerable<Product> GetAll();

        Product GetProductById(int id);
        int Delete(Product product);
        int Add(Product product);
        int Update(Product product);       

    
    }
}

