using Ardalis.HttpClientTestExtensions;
using QRoaster.API;
using QRoaster.Infrastructure.Entities;
using Xunit;

namespace QRoaster.API.FunctionalTests.ApiEndpoints;

[Collection("Sequential")]
public class UserList : IClassFixture<IntegrationTestsWebApplicationFactory<WebMarker>>
{
    private readonly HttpClient _client;

    public UserList(IntegrationTestsWebApplicationFactory<WebMarker> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsAllUsers()
    {
        var result = await _client.GetAndDeserializeAsync<List<User>>("/api/user");

        Assert.True(result != null);
    }
}
