using Azure.Storage.Blobs;
using Ecommerce_Api.Data;
using Ecommerce_Api.Models;
using Ecommerce_Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//********************************************************************************************************************************

// These are all the new additions

//Here  the class that connects the dbcontext is applicationdbcontext file so we are making use it is connect to our db
builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtSQLConnection"));
    });

//we add a singleton implementation for the blob service client
builder.Services.AddSingleton(u => new BlobServiceClient(
    builder.Configuration.GetConnectionString("StorageAccount")));

builder.Services.AddSingleton<IBlobService, BlobService>();
//Here we make sure to speficy the idenity for all the tables we have so we have user and thier role and the fact that we are using entity framewrok core
//old
//builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

// new here we switch from idenity user to application user class we created 
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();


//they stop here
//********************************************************************************************************************************

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
