using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Business;
using DataAccess;
//using DataAccess.Concretes.InMemory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Singleton-Scoped-Transient => Lifetime
//Singleton => Üretilen baðýmlýlýk uygulama açýk olduðu sürece tek bir kere new lenir.
//Her enjeksiyonda o instance kullanýlýr.
//Scoped => (API isteði)Ýstek baþýna bir instance oluþturur.
//Transient => Her adýmda (her talepte) yeni bir instance.

builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();

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