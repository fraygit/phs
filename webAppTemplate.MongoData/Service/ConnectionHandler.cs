﻿using System;
using MongoDB.Driver;
using Phs.MongoData.Entities.Base;
using System.Configuration;

namespace Phs.MongoData.Service
{

    public class ConnectionHandler<T> where T : IMongoEntity
    {
        public IMongoCollection<T> MongoCollection { get; set; }

        public ConnectionHandler(string connectionString)
        {
            try
            {
                var mongoClient = new MongoClient(connectionString);

                var defaultDb = ConfigurationManager.AppSettings["DB"];
                var db = mongoClient.GetDatabase(defaultDb);

                MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower() + "s");
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect to the database. Please contact your administrator.");
            }

        }
    }

}
