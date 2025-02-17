using Microsoft.AspNetCore.Mvc;
using NewsApp.Application.UseCases;
using NewsApp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly GetNewsUseCase _getNewsUseCase;

        public NewsController(GetNewsUseCase getNewsUseCase)
        {
            _getNewsUseCase = getNewsUseCase;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsDto>>> GetNews()
        {
            var news = await _getNewsUseCase.ExecuteAsync();
            return Ok(news);
        }
    }
}