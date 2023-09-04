using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestServices
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) => 
            this.storageBroker = storageBroker;

        public ValueTask<Guest> AddGuestAsync(Guest guest)
        {
            return this.storageBroker.InsertGuestAsync(guest);
        }
    }
}
