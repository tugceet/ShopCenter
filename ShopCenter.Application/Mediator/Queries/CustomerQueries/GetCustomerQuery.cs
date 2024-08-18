using MediatR;
using ShopCenter.Application.Mediator.Results.CustomerResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Mediator.Queries.CustomerQueries
{
    public class GetCustomerQuery: IRequest<List<GetCustomerQueryResult>> 

    {
    }
}
