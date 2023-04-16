using Grpc.Core;
using Microsoft.Extensions.Logging;
using ProductsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCService.Services
{
    public class gRpcCRUDService:ProductService.ProductServiceBase
    {
        private readonly List<Product> _products = new List<Product>();
        private int idCount = 0;
        private readonly ILogger<gRpcCRUDService> _logger;

        public gRpcCRUDService(ILogger<gRpcCRUDService> logger)
        {
            _logger = logger;
            _products.Add(new Product
            {
                Amount = 10,
                Brand = "Apple",
                Name = "IPhone  14",
                Price = 70,
                ProductId = 1
            });

        }

        public override Task<ProductList> GetAll(Empty request, ServerCallContext context)
        {
            ProductList lstproducts = new ProductList();
            lstproducts.Products.AddRange(_products);
            return Task.FromResult(lstproducts);
        }

        public override Task<Product> Get(ProductId request, ServerCallContext context)
        {
            return Task.FromResult(  _products.Find(x => x.ProductId == request.Id));
        }

        public override Task<Product> Insert(Product request, ServerCallContext context)
        {
            request.ProductId = idCount++;
            _products.Add(request);
            return Task.FromResult(request);
        }

        public override Task<Product> Update(Product request, ServerCallContext context)
        {
            var search = _products.FirstOrDefault(x => x.ProductId == request.ProductId);
            if(search != null)
            {
                search.Amount = request.Amount;
                search.Brand = request.Brand;
                search.Name = request.Name;
                search.Price = request.Price;
                return Task.FromResult(request);
            }

            return Task.FromException<Product>(new EntryPointNotFoundException());
        }

        public override  Task<Empty> Delete(ProductId request, ServerCallContext context)
        {
            var search = _products.FirstOrDefault(x => x.ProductId == request.Id);
            if (search != null)
            {
                _products.Remove(search);
                return Task.FromResult(new Empty());
            }
            return Task.FromException<Empty>(new EntryPointNotFoundException());
        }

    }
}
