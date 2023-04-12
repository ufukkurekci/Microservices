using Contact.API.Infrastructure;
using Contact.API.Service;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// default port :1000
builder.WebHost.ConfigureKestrel(options =>
{
	options.ListenAnyIP(9000);
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IContactService, ContactService>();
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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
