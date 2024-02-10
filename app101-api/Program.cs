var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(opt => opt.AddPolicy("cors", policy =>
{
    policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
        

    
}));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors("cors");
app.UseAuthorization();

app.MapControllers();

app.Run();
