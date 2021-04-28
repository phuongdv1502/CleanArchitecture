using CleanArchitecture.Application.Models.Product.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Models.Product.RequestModel
{
   public class ProductTypeQuery:IRequest<ProductTypeQueryResponseModel>
    {
        public Guid ProductTypeID { get; set; }
    }
}
