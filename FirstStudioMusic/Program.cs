using FirstStudioMusic.Application.ConfigProfile;
using FirstStudioMusic.Application.Services.CustomerService;
using FirstStudioMusic.Application.Services.OwnerService;
using FirstStudioMusic.Application.Services.StudioService;
using FirstStudioMusic.Application.Services.TransactionDetails;
using FirstStudioMusic.Application.Services.TransactionDetailsService;
using FirstStudioMusic.Application.Services.TransactionService;
using FirstStudioMusic.Database;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// DbContext
var connectionString = builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<StudioContext>(options => options.UseSqlServer(connectionString));

// Add AutoMapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ConfigurationProfile());
});
var mapper = config.CreateMapper();

// Add services to the container.
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<ICustomerAppService, CustomerAppService>();
builder.Services.AddTransient<IOwnerAppService, OwnerAppService>();
builder.Services.AddTransient<IStudioAppService, StudioAppService>();
builder.Services.AddTransient<ITransactionAppService, TransactionAppService>();
builder.Services.AddTransient<ITransactionDetailAppService, TransactionDetailAppService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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