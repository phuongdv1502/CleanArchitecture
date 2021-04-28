using CleanArchitecture.Application.Models.Product.RequestModel;
using CleanArchitecture.Application.Models.Product.ResponseModel;
using CleanArchitecture.Infrastructure.DatabaseServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using CleanArchitecture.Application.DatabaseServices;

namespace CleanArchitecture.Infrastructure.Handler.Product
{
    public class ProductTypeQueryHandler : IRequestHandler<ProductTypeQuery, ProductTypeQueryResponseModel>
    {
        private readonly IDapper _dapper;
        public ProductTypeQueryHandler(IDapper dapper)
        {
            _dapper = dapper;
        }
        public async Task<ProductTypeQueryResponseModel> Handle(ProductTypeQuery request, CancellationToken cancellationToken)
        {

            return await _dapper.Get<ProductTypeQueryResponseModel>($"select * from ProductType where ProductTypeID=" + request.ProductTypeID, null, CommandType.Text);
        }
    }
}
