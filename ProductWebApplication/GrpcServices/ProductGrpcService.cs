using ProductsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWebApplication.GrpcServices
{
    public class ProductGrpcService
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        private readonly ProductService.ProductServiceClient _serviceClient;
#pragma warning restore CS0436 // Type conflicts with imported type

#pragma warning disable CS0436 // Type conflicts with imported type
        public ProductGrpcService(ProductService.ProductServiceClient serviceClient)
#pragma warning restore CS0436 // Type conflicts with imported type
        {
            _serviceClient = serviceClient ?? throw new ArgumentNullException(nameof(serviceClient));
           
        }




    }
}
