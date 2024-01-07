using IMS.Utilities;
using Services.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddAutoMapper();
builder.Services.ConfigIdentityService();

builder.Services.AddBussinessService(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.AddJWTAuthentication(builder.Configuration["Jwt:Key"], builder.Configuration["Jwt:Issuer"]);
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithOrigins("http://localhost:3000", "https://ims.hisoft.vn", "http://localhost:8000"
        );
}));
builder.Services.AddSignalR();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.DisplayRequestDuration());
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();

    endpoints.MapHub<NotificationHub>("/notificationHub");
});

app.UseStaticFiles();

app.MapControllers();

app.Services.ApplyPendingMigrations();

app.UseForwardedHeaders();

app.Run();
