using MediatR;
using MediatR_TEST.Entities;

namespace MediatR_TEST.Queries
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomersQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll().ToList();
            //return await _repository.GetAll().ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
