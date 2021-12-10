using MediatR;
using MediatR_TEST.Entities;

namespace MediatR_TEST.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
