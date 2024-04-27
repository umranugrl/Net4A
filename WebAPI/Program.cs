using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Singleton-Scoped-Transient => Lifetime
//Singleton => �retilen ba��ml�l�k uygulama a��k oldu�u s�rece tek bir kere new lenir.
//Her enjeksiyonda o instance kullan�l�r.
//Scoped => (API iste�i)�stek ba��na bir instance olu�turur.
//Transient => Her ad�mda (her talepte) yeni bir instance.

builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductRepository, EfProductRepository>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryRepository, EfCategoryRepository>();

builder.Services.AddDbContext<BaseDbContext>();

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