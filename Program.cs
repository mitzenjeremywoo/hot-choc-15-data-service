using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Accounts.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserContext>(options =>
    options.UseInMemoryDatabase("InMemoryBloggingDb"));

builder.Services
    .AddScoped<UserRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddMutationType<Mutation>()
    .AddGlobalObjectIdentification();

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);
