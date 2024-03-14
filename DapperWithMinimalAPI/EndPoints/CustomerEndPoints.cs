using Dapper;
using DapperWithMinimalAPI.Models;
using DapperWithMinimalAPI.Services;
using Microsoft.Data.SqlClient;

namespace DapperWithMinimalAPI.EndPoints
{
    public static class CustomerEndPoints
    {
        public static void MapCustomerEndPoints(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("account", async (SqlConnectionFactory connectionFactory) => {

                using var connection = connectionFactory.Create();
                const string sql = "select * from Account";
                var accounts = await connection.QueryAsync<Account>(sql);
                return Results.Ok(accounts);
            });


        }
    }
}
