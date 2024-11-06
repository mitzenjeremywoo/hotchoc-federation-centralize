using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<InventoryInfoRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddGlobalObjectIdentification()
    .RegisterService<InventoryInfoRepository>();

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);

