using FluentAssertions;
using Moq;
using Sheenam.Api.Models.Foundation.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests
{    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldAddGuestAsync()
        {

            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest = returningGuest;

            this.storageBrokerMock.Setup(broker => 
            broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(randomGuest);

            Guest actualGuest = await 
                this.guestServices.AddGuestAsync(inputGuest);

            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker => 
                broker.InsertGuestAsync(inputGuest), Times.Once);


            this.storageBrokerMock.VerifyNoOtherCalls();
        }

    }
}