using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Accounts.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<UserRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddGlobalObjectIdentification()
    .RegisterService<UserRepository>();

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);
