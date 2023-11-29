using API_Batya;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDataContext, DataContext>();

#region �� �������
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
#region �� �������
app.UseCors("APolicy");
#endregion
app.UseAuthorization();

app.MapControllers();

app.Run();
