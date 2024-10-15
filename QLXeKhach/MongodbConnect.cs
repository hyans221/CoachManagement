using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeKhach
{
    public class MongodbConnect
    {
        private static MongoClient _client;
        private static IMongoDatabase _database;

        public static void InitializeConnection()
        {
            if (_client == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MongoDbConnectionString"].ConnectionString;

                _client = new MongoClient(connectionString);

                string dbName = connectionString.Split('/').Last();

                _database = _client.GetDatabase(dbName);
            }
        }

        public static IMongoDatabase GetDatabase()
        {
            if (_database == null)
            {
                InitializeConnection();
            }
            return _database;
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return GetDatabase().GetCollection<T>(collectionName);
        }
    }
}
