using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

const string Accounts = "accounts";
const string Inventory = "inventory";
const string Products = "products";
const string Reviews = "reviews";

builder.Services.AddHttpClient(Accounts, c => c.BaseAddress = new Uri("http://localhost:5051/graphql"));
builder.Services.AddHttpClient(Inventory, c => c.BaseAddress = new Uri("http://localhost:5052/graphql"));
builder.Services.AddHttpClient(Products, c => c.BaseAddress = new Uri("http://localhost:5053/graphql"));
builder.Services.AddHttpClient(Reviews, c => c.BaseAddress = new Uri("http://localhost:5054/graphql"));

builder.Services
    .AddGraphQLServer()
                //   .AddQueryType(d => d.Name("Query"))
                .AddRemoteSchema(Accounts)
                .AddRemoteSchema(Inventory)
                .AddRemoteSchema(Products)
                .AddRemoteSchema(Reviews)
                .AddTypeExtensionsFromFile("./Stitching.graphql");

var app = builder.Build();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);