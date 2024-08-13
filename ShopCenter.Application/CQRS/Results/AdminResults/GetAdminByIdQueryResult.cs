using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.CQRS.Results.AdminResults
{
    public class GetAdminByIdQueryResult
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
