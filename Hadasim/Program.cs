using Microsoft.EntityFrameworkCore;
using Services;

using Entities.DBModels;
using Repository;

var builder = WebApplication.CreateBuilder(args);

string connectionString = "Data Source=DESKTOP-IO6UM71; Initial Catalog = Hadasim; Integrated Security = True;TrustServerCertificate=True;";
// Add services to the container.

builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();

builder.Services.AddControllers();

builder.Services.AddDbContext<HadasimContext>(options => options.UseSqlServer(connectionString));

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
