using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPlayerRepository Players { get; }
        IRoomRepository Rooms { get; }
        IBookingRepository Bookings { get; }

        


    }
}
