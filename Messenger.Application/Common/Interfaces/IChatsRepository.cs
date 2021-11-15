﻿using Messenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Application.Common.Interfaces
{
    public interface IChatsRepository : IRepository<Chat> { }
}
