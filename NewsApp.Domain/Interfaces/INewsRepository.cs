using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Domain.Interfaces
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> GetAllAsync();
        Task UpsertAsync(News news);
    }
}