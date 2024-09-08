using Carter;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the Container.
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure HTTP Rewuest Pipeline
app.MapCarter();

app.Run();
