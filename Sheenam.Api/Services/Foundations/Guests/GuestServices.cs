using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestServices : IGuestServices
    {
        private readonly IStorageBroker storageBroker;

        public GuestServices(IStorageBroker storageBroker) => this.storageBroker = storageBroker;
        public ValueTask<Guest> AddGuestAsync(Guest guest)
        {
            throw new NotImplementedException();
        }
    }
}
