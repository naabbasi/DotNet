using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.System.Controllers;

public class TestUserController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnStatusCode200()
    {
        //Arrange
        var mockUserService = new Mock<IUserService>();
        mockUserService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(UserFixture.GetTestUsers);

        var sut = new UsersController(mockUserService.Object);
        //Act
        var result = (OkObjectResult) await sut.Get();

        //Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesUserServiceExactlyOnce()
    {
        //Arrange
        var mockUserService = new Mock<IUserService>();
        mockUserService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);

        //Act
        var result = (NotFoundResult) await sut.Get();

        //Assert
        mockUserService.Verify(service => service.GetAllUsers(), Times.Once);
    }

    [Fact]
    public async Task Get_OnSuccess_ReturnListOfUsers()
    {
        //Arrange
        var mockUserService = new Mock<IUserService>();
        mockUserService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(UserFixture.GetTestUsers);

        var sut = new UsersController(mockUserService.Object);

        //Act
        var result = (OkObjectResult) await sut.Get();

        //Assert
        result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult) result;
        objectResult.Value.Should().BeOfType<List<User>>();
    }

    [Fact]
    public async Task Get_OnNoUsersFound_Return404()
    {
        //Arrange
        var mockUserService = new Mock<IUserService>();
        mockUserService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);

        //Act
        var result = (NotFoundResult)await sut.Get();

        //Assert
        result.Should().BeOfType<NotFoundResult>();
    }

    [Theory]
    [InlineData("foo", 1)]
    [InlineData("bar", 1)]
    public void Test2(string input, int bar)
    {

    }
}