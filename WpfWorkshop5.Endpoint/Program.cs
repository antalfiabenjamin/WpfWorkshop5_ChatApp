using WpfWorkshop5.Endpoint.Services;
using WpfWorkshop5.Logic;
using WpfWorkshop5.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IRepository<Message>, MessageRepository>();
builder.Services.AddTransient<IMessageLogic, MessageLogic>();

builder.Services.AddSignalR();

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

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<SignalRHub>("/hub");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
