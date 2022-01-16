using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab1.Entities;

namespace Wsei.Lab1.Services
{
    public interface IChatMessagesRepository
    {
        void Add(ChatMessageEntity message);

        IEnumerable<ChatMessageEntity> GetAll();
    }
}
