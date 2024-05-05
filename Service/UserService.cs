using System.Net;
using FlightApi.Interface;
using FlightApi.model;
using MongoDB.Bson;
using FlightApi.Dtos;
using FlightApi.Helpers;
using MongoDB.Driver;

namespace FlightApi.Service
{
  public class UserService : IUserAction
  {
    private const string DatabaseName = "flightApi";
    private const string UserCollectionName = "User";
    private readonly IMongoCollection<User> UserCollections;
    private readonly FilterDefinitionBuilder<User> filterBuilder = Builders<User>.Filter;

    public UserService(IMongoClient mongoClient)
    {
      IMongoDatabase database = mongoClient.GetDatabase(DatabaseName);
      UserCollections = database.GetCollection<User>(UserCollectionName);
    }

    public async Task<User> loginAsync(loginDto loginDto)
    {
      try
      {
        var filter = filterBuilder.Eq(user => user.email, loginDto.email);
        return await UserCollections.Find(filter).FirstOrDefaultAsync();
      }
      catch (Exception e)
      {
        throw new UnprocessableEntityException(e.Message);
      }
    }
    public async Task<User> registerUserAsync(User user)
    {
      try
      {
        var filter = filterBuilder.Eq(user => user.email, user.email);
        var userExist = await UserCollections.Find(filter).FirstOrDefaultAsync();
        if (userExist != null) throw new UnprocessableEntityException("User Exist");
        await UserCollections.InsertOneAsync(user);
        return user;

      }
      catch (Exception e)
      {

        throw new UnprocessableEntityException(e.Message);
      }
    }
    public async Task<bool> forgetPassword(forgetPasswordDto data)
    {
      try
      {
        var filter = filterBuilder.Eq(existingUsers => existingUsers.email, data.email);
        var userExist = await UserCollections.Find(filter).FirstOrDefaultAsync();
        if (userExist != null)
        {
          //send email to user
          using(HttpClient httpClient = new HttpClient()){
            var httpClientRespone = await  httpClient.GetAsync("");

          }
          return true;
        }
        return false;
      }
      catch (Exception e)
      {
        throw new UnprocessableEntityException(e.Message);
      }
    }
  }
}