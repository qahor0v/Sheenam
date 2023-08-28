using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {

        ValueTask<Guest> InsertGuestAsync(Guest guest);

    }
}
