using Business;
using Core;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.Utilities.Encryption;
using DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using TokenOptions = Core.Utilities.JWT.TokenOptions;
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

TokenOptions? tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();
builder.Services.AddCoreServices(tokenOptions);

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionMiddlewareExtensions();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();