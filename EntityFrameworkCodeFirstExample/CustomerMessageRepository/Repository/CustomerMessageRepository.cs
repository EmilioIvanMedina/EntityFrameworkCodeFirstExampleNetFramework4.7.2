using CustomerMessageApplication.DTOs;
using CustomerMessageApplication.Interfaces;
using CustomerMessageRepository.DatabaseModel;
using CustomerMessageRepository.Entities;
using System.Threading.Tasks;

namespace CustomerMessageRepository.Repository
{
    public class CustomerMessageRepository : ICustomerMessageRepository
    {
        private readonly CustomerMessageDbContext _context;

        public CustomerMessageRepository(CustomerMessageDbContext context)
        {
            _context = context;
        }

        public async Task SaveMesssage(CustomerMessageDTO messageDto)
        {
            var message = new CustomerMessage
            {
                Email = messageDto.Email,
                IdCustomerMessage = messageDto.IdCustomerMessage,
                Message = messageDto.Message,
                Name = messageDto.Name
            };

            _context.CustomerMessages.Add(message);

            _context.SaveChangesAsync();
        }
    }
}
