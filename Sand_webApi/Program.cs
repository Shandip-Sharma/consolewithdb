using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sand_webApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddDbContext<ContactContext>(Options=> Options.UseInMemoryDatabase("db_Contact"));
builder.Services.AddDbContext<ContactContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Sand_webApiConnectionStrings")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
