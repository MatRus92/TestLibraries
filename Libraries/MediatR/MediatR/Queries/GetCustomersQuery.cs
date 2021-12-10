using MediatR;
using MediatR_TEST.Entities;

namespace MediatR_TEST.Queries
{
    public class GetCustomersQuery : IRequest<List<Customer>>
    {
    }
}
