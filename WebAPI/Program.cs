using Business.Abstracts;
using Business.Concretes;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
//using DataAccess.Concretes.InMemory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Singleton-Scoped-Transient => Lifetime
//Singleton => �retilen ba��ml�l�k uygulama a��k oldu�u s�rece tek bir kere new lenir.
//Her enjeksiyonda o instance kullan�l�r.
//Scoped => (API iste�i)�stek ba��na bir instance olu�turur.
//Transient => Her ad�mda (her talepte) yeni bir instance.

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductRepository, EfProductRepository>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>();

builder.Services.AddDbContext<BaseDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionMiddlewareExtensions();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();