using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab1.Entities;

namespace Wsei.Lab1.Services
{
    public class ChatMessageRepository : IChatMessagesRepository
    {
        private readonly List<ChatMessageEntity> _messages = new List<ChatMessageEntity>();

        public void Add(ChatMessageEntity message)
        {
            _messages.Add(message);
        }

        public IEnumerable<ChatMessageEntity> GetAll()
        {
            return _messages;
        }
    }
}
