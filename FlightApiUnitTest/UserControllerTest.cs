using System;
using Xunit;
using Moq;
using FlightApi.Dtos;
using FlightApi.Interface;
using FlightApi.Controllers;

namespace FlightApiUnitTest;

public class UserControllerTest
{
    [Fact]
    public async Task loginAsync_withUnexistingItem_ReturnBadRequest()
    {

        //Arrange
        loginDto data = new() { email = "oweure", password = "jehhoij" };
        var userServiceStub = new Mock<IUserAction>();
        userServiceStub.Setup(repo => repo.loginAsync(data)).ReturnAsync(null);
        var jwtService = new Mock<IJwtAction>();

        var userController = new UserController(userServiceStub.Object, jwtService);


        //Act 
        var result = await userController.loginAsync(null);


        //Assert
        Assert.IsType<BadRequest>(result.Result);

    }
}