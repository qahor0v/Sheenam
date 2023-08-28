using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    [Keyless]
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests{ get; set; }
    }
}
