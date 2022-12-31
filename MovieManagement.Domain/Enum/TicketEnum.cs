using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Domain.Enum
{
    [Flags]
    public enum TicketEnum
    {
        Bought,
        Reserved,
        Cancelled
    }
}
