using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Business.Concrete;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Data.Concrete;
using OtelRezervasyon.Data.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IStaffDal, EfCoreStaffDal>();
builder.Services.AddScoped<IStaffService,StaffManager>();

builder.Services.AddScoped<IRoomDal, EfCoreRoomDal>();
builder.Services.AddScoped<IRoomService,RoomManager>();

builder.Services.AddScoped<ISubscribeDal, EfCoreSubscribeDal>();
builder.Services.AddScoped<ISubscribeService,SubscribeManager>();

builder.Services.AddScoped<ITestimonialDal, EfCoreTestimonialDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialManager>();

builder.Services.AddScoped<IServiceDal, EfCoreServiceDal>();
builder.Services.AddScoped<IServiceService,ServiceManager>();

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


