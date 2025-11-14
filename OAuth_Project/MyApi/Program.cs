using MyApi.Services; // Ensure this matches your namespace for ProductService

var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services.AddControllers();

// Register ProductService for IProductService
builder.Services.AddSingleton<ProductService>();

var app = builder.Build();

app.MapControllers();

app.Run();