using Training.CircleSquareGame.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://localhost")
                .AllowAnyHeader()
                .WithMethods("GET", "POST")
                .AllowCredentials()
                .SetIsOriginAllowed(s => true);
        });
});

var app = builder.Build();
app.UseCors();
app.MapHub<XOHub>("/xohub");
app.Run("http://localhost:5000");