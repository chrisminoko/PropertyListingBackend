using Property48.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository properties { get; }
        IAreaRepository Areas { get; }
        ICityRepository cities  {get ;}
        Task<int> CommitAsync();

        
    }
}
