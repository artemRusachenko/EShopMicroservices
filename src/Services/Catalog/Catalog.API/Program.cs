using Microsoft.CodeAnalysis.VisualBasic.Syntax;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();//For implementing CRUD operations

var app = builder.Build();

// Configure thr HTTP request pipeline
app.MapCarter();

app.Run();
