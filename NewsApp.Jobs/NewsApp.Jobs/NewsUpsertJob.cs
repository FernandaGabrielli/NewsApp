using NewsApp.Application.UseCases;
using NewsApp.Domain.Interfaces;

namespace NewsApp.Jobs
{
    public class NewsUpsertJob
    {
        private readonly INewsRepository _newsRepository;

        public NewsUpsertJob(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task ExecuteAsync()
        {
            // Consumir a API de notícias e upsert no banco de dados
        }
    }
}