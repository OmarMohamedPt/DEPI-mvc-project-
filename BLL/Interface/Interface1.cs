using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface Interface1
    {
        IEnumerable<Product> GetAll();

        Product Get(int id);   
        int Add(Product product);
        int Update(Product product);
        int Delete(Product product);
       

    
    }
}
