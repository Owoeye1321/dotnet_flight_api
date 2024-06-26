using System.Net;
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
    public UserController()
    {
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
        var data = A.Fake<loginDto>();
        var user = A.Fake<IUser>();
        var id = A.Fake<Guid>();
        var token = A.Fake<string>();
        A.CallTo(() => userService.loginAsync(data)).Returns(user);
        A.CallTo(() => jwtService.Generatejwt(id)).Returns(token);



        //Act 
        var result = userController.loginAsync(data)


        //Assert
        result.Should().Be<Task<ActionResult>>();
        result.code.Should().Be<HttpStatusCode.Ok>();
        result.token.Should().NotBeNull();
        result.data.Should().BeOfType<IUser>();

    }
    [Fact]
    public void UserController_registerUserAsync_ReturnSuccess(){
        //Arrange
        var userDetail = A.Fake<IUser>();
        var userDto = A.Fake<userDto>();
        vat token = A.Fake<string>();
        A.CallTo(()=> userService.registerUserAsync(userDetail)).Returns(userDetails);
         A.CallTo(() => jwtService.Generatejwt(userDetail.id)).Returns(token);

        //Act 
        var result = userController.registerUserAsync(userDto)

        //Assert
        result.Should().Be<Task<ActionResult>>();
        result.code.Should().Be<HttpStatusCode.Ok>();
        result.token.Should().NotBeNull();
        result.data.Should().BeOfType<IUser>();
        
        
    }
    [Fact]
    public void UserController_forgetPassword_ReturnSuccess(){
        
    }
}