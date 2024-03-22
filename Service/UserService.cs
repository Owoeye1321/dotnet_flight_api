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

    public UserService(IMongoClient mongoClient){
     IMongoDatabase database = mongoClient.GetDatabase(DatabaseName);
      UserCollections = database.GetCollection<User>(UserCollectionName);
    }

      public async Task loginAsync(loginDto loginDto){
         try
         {

         }
         catch (Exception e)
         { 
            throw new UnprocessableEntityException(e.Message);
         }
      }
      public async Task<User> registerUserAsync(User user){
         try
         {
          await UserCollections.InsertOneAsync(user);
          return user;

         }
         catch (Exception e)
         {
          
            throw new UnprocessableEntityException(e.Message);
         }
    }
  }
}