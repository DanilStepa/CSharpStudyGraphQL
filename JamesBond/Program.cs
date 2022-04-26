using JamesBond;
using JamesBond.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5434;Database=bond;Username=bond;Password=bond"));


builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddInMemorySubscriptions()
    .AddSubscriptionType<Subscription>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

var app = builder.Build();

app.UseWebSockets();
app.MapGraphQL("/api");

app.Run();