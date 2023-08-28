using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    [Keyless]
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests{ get; set; }

        public async ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Guest> entityEntry = await broker.Guests.AddAsync(guest);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }

    }
}
