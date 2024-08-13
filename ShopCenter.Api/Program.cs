using Microsoft.EntityFrameworkCore;
using ShopCenter.Application.CQRS.Handlers.AdminHandlers;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;
using ShopCenter.Infrastructure.Context;
using ShopCenter.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the DbContext
builder.Services.AddDbContext<ShopCenterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Register repositories
builder.Services.AddScoped<IRepository<Admin>, Repository<Admin>>();


builder.Services.AddScoped<ShopCenterContext, ShopCenterContext>();
builder.Services.AddScoped<GetAdminQueryHandler>();
builder.Services.AddScoped<GetAdminByIdQueryHandler>();
builder.Services.AddScoped<CreateAdminCommandHandler>();
builder.Services.AddScoped<UpdateAdminCommandHandler>();
builder.Services.AddScoped<RemoveAdminCommandHandler>();

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
