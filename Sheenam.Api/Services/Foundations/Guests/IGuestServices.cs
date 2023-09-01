using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.Api.Services.Foundations.Guests;

public interface IGuestServices
{
    ValueTask<Guest> AddGuestAsync(Guest guest);
}
