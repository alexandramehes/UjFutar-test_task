using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using UjFutar;
using UjFutar.Api.Interface;
using UjFutar.Database;
using UjFutar.EsemenyTar.Api;
using UjFutar.MemoryEsemenyTar;
using UjFutar.Repository.Interface;
using UjFutar.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ISzemelyRepository, SzemelyRepository>();
builder.Services.AddScoped<ICsomag, CsomagRepository>();
builder.Services.AddSingleton<IEsemenyTar, MemoryEsemenyTar>();

builder.Services.AddDbContext<UjFutarContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
