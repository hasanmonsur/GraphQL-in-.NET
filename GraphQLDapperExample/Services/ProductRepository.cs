using Dapper;
using GraphQLDapperExample.Models;
using Microsoft.Data.SqlClient;

namespace GraphQLDapperExample.Services
{
    public class ProductRepository 
    {
        private readonly DapperContext _dapperContext;

        public ProductRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using var connection = _dapperContext.CreateDbConnection();
            return connection.Query<Product>("SELECT * FROM Products");
        }
    }
}
