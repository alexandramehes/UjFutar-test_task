using UjFutar.Database;
using UjFutar.Repository.Interface;
using UjFutar.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<UjFutarContext>();
builder.Services.AddScoped<ISzemelyRepository, SzemelyRepository>();

