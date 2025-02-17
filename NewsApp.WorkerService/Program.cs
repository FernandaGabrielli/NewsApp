using Hangfire;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewsApp.Jobs;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHangfire(config =>
{
    config.UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddHangfireServer();

builder.Services.AddTransient<NewsUpsertJob>();

var host = builder.Build();

RecurringJob.AddOrUpdate<NewsUpsertJob>(
    "news-upsert", 
    job => job.ExecuteAsync(), 
    Cron.Hourly 
);


host.Run();