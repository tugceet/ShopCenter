using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Mediator.Commands.CustomerCommands
{
    public class UpdateCustomerCommand : IRequest
    {
        public DateTime CreatedDate { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

}
