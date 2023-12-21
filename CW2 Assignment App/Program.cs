using CW2_Assignment_App.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddDbContext<UserDBContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwaggerUI();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

//seeding the data
void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeder>();
        service.Seed();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger(x => x.SerializeAsV2 = true  ) ;
//get function 
app.MapGet("/", () => "Hello World!");

app.MapGet("/user", (Func<CW2_Assignment_App.Model.User>)(()=>{
    return new CW2_Assignment_App.Model.User()
    {
        userID = "1",
        
        email = "grace@plymouth.ac.uk",
        password = "ISAD123!"
    };

}));

app.MapGet("/users/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetUserById(id);
});


app.MapGet("/users", ([FromServices] IDataRepository db) =>
    {
        return db.GetUsers();
    }
);

//put function
app.MapPut("/users/{id}", ([FromServices] IDataRepository db, User user) =>
{
    db.PutUsers(user);
});

//post function 
app.MapPost("/users", ([FromServices] IDataRepository db, User user) =>
{
    db.AddUser(user);
});


//app.MapGet("/user/{id}", async (http) =>
//{
//    if (!http.Request.RouteValues.TryGetValue("id", out var id))
//    {
//        http.Response.StatusCode = 400;
//    }
//    else
//    {
//        await http.Response.WriteAsJsonAsync(new UserCollection()
//            .GetUser()
//            .FirstOrDefault(x => x.userID == (string)id));
//    }
//});

app.Run();
