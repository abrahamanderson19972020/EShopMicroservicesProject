var builder = WebApplication.CreateBuilder(args);

// Add Services to the Container.


var app = builder.Build();

// Configure HTTP Rewuest Pipeline


app.Run();
