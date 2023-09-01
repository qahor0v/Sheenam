using FluentAssertions.Common;
using Sheenam.Api.Brokers.Storages;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

         
        builder.Services.AddDbContext<StorageBroker>();

        builder.Services.AddTransient<IStorageBroker, StorageBroker>();

        builder.Services.AddControllers();
         builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

         if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}