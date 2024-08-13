using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.CQRS.Queries
{
    public class GetAdminByIdQuery
    {
        public GetAdminByIdQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }


    }
}
