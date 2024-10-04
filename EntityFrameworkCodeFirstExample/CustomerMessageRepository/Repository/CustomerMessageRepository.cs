using CustomerMessageApplication.DTOs;
using CustomerMessageApplication.Interfaces;
using System.Threading.Tasks;

namespace CustomerMessageRepository.Repository
{
    public class CustomerMessageRepository : ICustomerMessageRepository
    {
        public Task SaveMesssage(CustomerMessageDTO message)
        {
            throw new System.NotImplementedException();
        }
    }
}
