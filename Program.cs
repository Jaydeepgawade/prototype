//var builder = WebApplication.CreateBuilder(args);

//// 1. Add services to the container
//builder.Services.AddControllers();

//// Optional: Add Swagger/OpenAPI support
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Allow Flutter web requests during development.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("FlutterCors", policy =>
//    {
//        policy.AllowAnyOrigin()
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});

//var app = builder.Build();

//// 2. Configure the HTTP request pipeline
////if (app.Environment.IsDevelopment())
////{
//    app.UseSwagger();
//    app.UseSwaggerUI();
////}

//app.UseHttpsRedirection();
//app.UseCors("FlutterCors");
//app.UseAuthorization();

//// 3. Map controller endpoints
//app.MapControllers();

//app.Run();

var builder = WebApplication.CreateBuilder(args);

// Get Railway's PORT or fallback to 8080
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://*:{port}");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("FlutterCors", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseCors("FlutterCors");
app.UseAuthorization();
app.MapControllers();
app.Run();
