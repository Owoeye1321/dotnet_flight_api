using FlightApi.Interface;
using FlightApi.model;
using MongoDB.Bson;
using FlightApi.Dtos;
using MongoDB.Driver;

namespace FlightApi.Service 
{
  public class UserService : IUserAction
  {
      private const string DatabaseName = "flightApi";
      private const string UserCollectionName = "User";
      private readonly IMongoCollection<User> UserCollections;

    public UserService(IMongoClient mongoClient){
     IMongoDatabase database = mongoClient.GetDatabase(DatabaseName);
      UserCollections = database.GetCollection<User>(UserCollectionName);
    }

    public async Task LoginAsync(LoginDto loginDto){

    }
      public async Task<User> RegisterUserAsync(User user){
      return user;
    }
  }
}