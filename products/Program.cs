using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Products.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<ProductRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
   // .AddGlobalObjectIdentification()
    .RegisterService<ProductRepository>();

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);
