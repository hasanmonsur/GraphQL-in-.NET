using GraphQLDapperExample.Models;
using GraphQLDapperExample.Services;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQLDapperExample.Data
{
    public class Query
    {
        public IEnumerable<Product> GetProducts([Service] ProductRepository repository) {
        
            return repository.GetAllProducts();
        }
            
    }

    public class ProductType : ObjectType<Product>
    {
    }
}
