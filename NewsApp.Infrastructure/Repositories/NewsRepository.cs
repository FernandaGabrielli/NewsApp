using System.Collections.Generic;
using System.Threading.Tasks;
using NewsApp.Domain.Entities;
using NewsApp.Domain.Interfaces;
using NewsApp.Infrastructure.Data;

namespace NewsApp.Infrastructure.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly AppDbContext _context;

        public NewsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<News>> GetAllAsync()
        {
            return await _context.News.ToListAsync();
        }

        public async Task UpsertAsync(News news)
        {
            var existingNews = await _context.News.FirstOrDefaultAsync(n => n.Title == news.Title);
            if (existingNews == null)
            {
                _context.News.Add(news);
            }
            else
            {
                existingNews.Description = news.Description;
                existingNews.PublishedAt = news.PublishedAt;
                existingNews.Source = news.Source;
            }
            await _context.SaveChangesAsync();
        }
    }
}