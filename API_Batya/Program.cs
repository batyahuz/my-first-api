var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region מה שהוספתי
builder.Services.AddCors(o => o.AddPolicy("APolicy", p =>
{
    p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
#region מה שהוספתי
app.UseCors("APolicy");
#endregion
app.UseAuthorization();

app.MapControllers();

app.Run();
