using MedicineProject.Core.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using MedicineProject.Core.Repository.IRepository;
using MedicineProject.Core.Repository;
using MedicineProject.Data.Entities.Appointments;
using MedicineProject.Core.Services.IServices;
using MedicineProject.Core.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MedicineProjectDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))); 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBaseRepository<Appointment>, BaseRepository<Appointment>>();
builder.Services.AddScoped<IBaseService<Appointment>, BaseService<Appointment>>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
