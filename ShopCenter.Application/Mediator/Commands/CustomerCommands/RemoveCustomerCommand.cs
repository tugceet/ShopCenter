using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Mediator.Commands.CustomerCommands
{
    public class RemoveCustomerCommand: IRequest
    {
        public Guid Id { get; set; }

        public RemoveCustomerCommand(Guid id)
        {
            Id = id;
        }
    }
}
