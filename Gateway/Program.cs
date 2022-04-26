using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient(SchemaNames.JamesBond, c => c.BaseAddress = new Uri("http://localhost:5175/api"));

builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema(SchemaNames.JamesBond);

var app = builder.Build();

app.MapGraphQL("/api");
app.Run();

class SchemaNames
{
    public const string JamesBond = "jamesbond";
}