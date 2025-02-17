using System.Collections.Generic;
using System.Threading.Tasks;
using NewsApp.Application.DTOs;
using NewsApp.Domain.Interfaces;

namespace NewsApp.Application.UseCases
{
    public class GetNewsUseCase
    {
        private readonly INewsRepository _newsRepository;

        public GetNewsUseCase(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<IEnumerable<NewsDto>> ExecuteAsync()
        {
            var news = await _newsRepository.GetAllAsync();
            return news.Select(n => new NewsDto
            {
                Title = n.Title,
                Description = n.Description,
                PublishedAt = n.PublishedAt,
                Source = n.Source
            });
        }
    }
}