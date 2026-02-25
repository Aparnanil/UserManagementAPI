using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔹 Error Handling Middleware (First)
app.UseMiddleware<ErrorHandlingMiddleware>();

// 🔹 Authentication Middleware (Second)
app.UseMiddleware<AuthenticationMiddleware>();

// 🔹 Logging Middleware (Last)
app.UseMiddleware<LoggingMiddleware>();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
