using System.Collections.Generic;
using System.Threading.Tasks;
using NewsApp.Domain.Entities;

namespace NewsApp.Domain.Interfaces
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> GetAllAsync();
        Task UpsertAsync(News news);
    }
}