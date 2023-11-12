using GameOnAPI.Data;
using GameOnAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Extensions.Configuration;
using GameOnAPI.Services;
using AutoMapper;
using GameOnAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers().AddJsonOptions(options =>
{
	options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

IMapper Mapper = MappingConfig.RegisterMaps().CreateMapper();

builder.Services.AddSingleton(Mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()) ;

builder.Services.AddScoped<IJWTTokenGenerator,JWTTokenGenerator>();

builder.Services.AddIdentity<User, IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
	.AddDefaultTokenProviders();

builder.Services.AddScoped<IAuthService, AuthService>();


builder.Services.Configure<JWTOptions>(builder.Configuration.GetSection("ApiSettings:JWTOptions"));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowReactApp", builder =>
	{
		builder.WithOrigins("http://localhost:3000")
			   .AllowAnyMethod()
			   .AllowAnyHeader();
	});
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("AllowReactApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

