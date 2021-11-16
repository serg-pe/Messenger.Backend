using Messenger.Application.Common.Interfaces;
using Messenger.Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Infrastructure.Persistence
{
    public class ChatsRepository : IChatsRepository
    {
        private readonly IMongoCollection<Chat> _chatsCollection;

        public ChatsRepository(IMongoCollection<Chat> chatsCollection) => _chatsCollection = chatsCollection;

        public async Task CreateAsync(Chat entity)
        {
            await _chatsCollection.InsertOneAsync(entity);
        }

        public async Task DeleteAsync(Chat entity)
        {
            var filter = Builders<Chat>.Filter
                .Eq(chat => chat.Id, entity.Id);
            await _chatsCollection.DeleteOneAsync(filter);
        }

        public async Task<IReadOnlyCollection<Chat>> GetAllAsync()
        {
            var chats = await _chatsCollection.FindAsync(FilterDefinition<Chat>.Empty);
            return await chats.ToListAsync();
        }

        public async Task<Chat> GetByIdAsync(Guid entityId)
        {
            var filter = Builders<Chat>.Filter
                .Eq(chat => chat.Id, entityId);
            var searchCursor = await _chatsCollection.FindAsync(filter);
            return await searchCursor.FirstAsync();
        }

        public async Task UpdateAsync(Chat entity)
        {
            var filter = Builders<Chat>.Filter
                .Eq(chat => chat.Id, entity.Id);
            await _chatsCollection.ReplaceOneAsync(filter, entity);
        }
    }
}
