using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MongoDB.Bson;
using MongoDB.Driver;
using BCrypt.Net;

namespace QLXeKhach
{
    using BCrypt.Net;

    public class UserService
    {
        private readonly IMongoCollection<BsonDocument> _userCollection;

        public UserService()
        {
            _userCollection = MongodbConnect.GetCollection<BsonDocument>("user");
        }

        public void CreateUser(string username, string password, string role)
        {
            string hashedPassword = BCrypt.HashPassword(password);
            var user = new BsonDocument
        {
            { "username", username },
            { "password", hashedPassword },
            { "role", role }
        };
            _userCollection.InsertOne(user);
        }

        public void UpdateUserPassword(string username, string newPassword)
        {
            var hashedPassword = BCrypt.HashPassword(newPassword);
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var update = Builders<BsonDocument>.Update.Set("password", hashedPassword);
            _userCollection.UpdateOne(filter, update);
        }
    }

    public class UserAuthentication
    {
        private readonly IMongoCollection<BsonDocument> _userCollection;

        public UserAuthentication()
        {
            _userCollection = MongodbConnect.GetCollection<BsonDocument>("user");
        }

        public bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = _userCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                var storedHashedPassword = user["password"].AsString;
                return BCrypt.Verify(password, storedHashedPassword);
            }

            return false;
        }

        public string GetUserRole(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = _userCollection.Find(filter).FirstOrDefault();

            return user?["role"].AsString;
        }
    }
}
