using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Data.Concrete;
using OtelRezervasyon.Data.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//API Services

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IStaffDal, EfCoreStaffDal>();
builder.Services.AddScoped<IRoomDal, EfCoreRoomDal>();
// Add services to the container.

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
