
using DapperWithMinimalAPI.EndPoints;
using DapperWithMinimalAPI.Services;

namespace DapperWithMinimalAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        builder.Services.AddScoped(serviceProvider =>
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("DeafaultConnectionString")??
                throw new ApplicationException("the connection string is null");
            return new SqlConnectionFactory(connectionString);
        });

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapCustomerEndPoints();

        app.Run();
    }
}
