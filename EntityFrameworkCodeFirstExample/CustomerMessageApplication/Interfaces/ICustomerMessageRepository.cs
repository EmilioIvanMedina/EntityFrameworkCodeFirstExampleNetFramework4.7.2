using CustomerMessageApplication.DTOs;
using System.Threading.Tasks;

namespace CustomerMessageApplication.Interfaces
{   
    public interface ICustomerMessageRepository
    {
        Task SaveMesssage(CustomerMessageDTO message);
    }
}
