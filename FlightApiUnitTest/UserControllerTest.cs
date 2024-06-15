using System;
using Xunit;
using Moq;
using FlightApi.Dtos;
using FlightApi.Interface;
using FlightApi.Controllers;

namespace FlightApiUnitTest;

public class UserControllerTest
{
        private readonly IUserAction userService;
        private readonly IJwtAction jwtService;
    public UserController(){
        //Dependencies
        userService = A.Fake<IUserAction>();
        jwtService = A.Fake<IJwtAction>();
        
        //Class
        userController = new UserController(userService, jwtService);
    }

    [Fact]
    public void UserController_loginAsync_ReturnSuccess()
    {

        //Arrange
        var data = A.Fake<loginDto>()


        //Act 
        var result = userController.loginAsync(data)


        //Assert

    }
}