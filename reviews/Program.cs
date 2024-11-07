using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Reviews.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<ReviewRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
  //  .AddGlobalObjectIdentification()
    .RegisterService<ReviewRepository>();

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);
