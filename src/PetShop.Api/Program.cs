using Microsoft.EntityFrameworkCore;
using PetShop.Data.Context;
using PetShop.Data.Repositories;
using PetShop.Domain.Interfaces.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PSContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PSConnection")));

builder.Services.AddScoped<IPetOwnerRepository,PetOwnerRepository>();
builder.Services.AddScoped<ICareProcedureRepository, CareProcedureRepository>();
builder.Services.AddScoped<IPetRepository, PetRepository>();
builder.Services.AddScoped<IProcedureRepository, ProcedureRepository>();
builder.Services.AddScoped<IVetCareRepository, VetCareRepository>();
builder.Services.AddScoped<IVetRepository, VetRepository>();

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
