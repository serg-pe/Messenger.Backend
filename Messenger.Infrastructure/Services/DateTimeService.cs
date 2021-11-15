using Messenger.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime CurrentDateTime => DateTime.Now;
    }
}
