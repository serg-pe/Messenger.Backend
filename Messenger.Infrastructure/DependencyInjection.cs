using Messenger.Application.Common.Interfaces;
using Messenger.Domain.Entities;
using Messenger.Infrastructure.Persistence;
using Messenger.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Messenger.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDbSection = configuration.GetSection("Dbs").GetSection("Mongo");
            var mongoDbConnectionString = mongoDbSection["ConnectionString"];
            var mongoDbCollections = mongoDbSection.GetSection("Collections");

            services.AddTransient<IChatsRepository, ChatsRepository>(sp =>
            {
                var client = new MongoClient(mongoDbConnectionString);
                var chatsDatabase = client.GetDatabase(mongoDbCollections["Chats"]);
                return new ChatsRepository(chatsDatabase.GetCollection<Chat>(mongoDbCollections["Chats"]));
            });

            services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }
    }
}
