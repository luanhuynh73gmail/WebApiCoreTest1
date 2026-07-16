var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Generates doc via Swashbuckle

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Exposes /swagger/v1/swagger.json
    app.UseSwaggerUI(); // Exposes interactive dashboard
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
