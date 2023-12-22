using CW2_Assignment_App.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddDbContext<UserDBContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();

    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        In = ParameterLocation.Header,
        Description = "Basic Auth Header"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "basic"
                        }
                    },
                    new string[]{ }
                }
            });
});


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
app.MapGet("/user", (Func<CW2_Assignment_App.Model.User>)(()=>{
    return new CW2_Assignment_App.Model.User()
    {
        userID = "1",
        
        email = "grace@plymouth.ac.uk",
        password = "ISAD123!"
    };

}));

//user ------------------------------------------------------------------------------------------
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

//Profile ---------------------------------------------------------------------------------------
app.MapGet("/Profile/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetProfileById(id);
});


app.MapGet("/Profile", ([FromServices] IDataRepository db) =>
{
    return db.GetProfile();
}
);

//put function
app.MapPut("/Profile/{id}", ([FromServices] IDataRepository db, Profile Profile) =>
{
    db.PutProfile(Profile);
});

//post function 
app.MapPost("/Profile", ([FromServices] IDataRepository db, Profile Profile) =>
{
    db.AddProfile(Profile);
});

//Badges ---------------------------------------------------------------------------------------
app.MapGet("/Badges/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetBadgesById(id);
});


app.MapGet("/Badges", ([FromServices] IDataRepository db) =>
{
    return db.GetBadges();
}
);

//put function
app.MapPut("/Badges/{id}", ([FromServices] IDataRepository db, Badges Badges) =>
{
    db.PutBadges(Badges);
});

//post function 
app.MapPost("/Badges", ([FromServices] IDataRepository db, Badges Badges) =>
{
    db.AddBadges(Badges);
});

//Trail ---------------------------------------------------------------------------------------
app.MapGet("/Trail/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetTrailById(id);
});


app.MapGet("/Trail", ([FromServices] IDataRepository db) =>
{
    return db.GetTrail();
}
);

//put function
app.MapPut("/Trail/{id}", ([FromServices] IDataRepository db, Trail Trail) =>
{
    db.PutTrail(Trail);
});

//post function 
app.MapPost("/Trail", ([FromServices] IDataRepository db, Trail Trail) =>
{
    db.AddTrail(Trail);
});


//Leaderboard ---------------------------------------------------------------------------------------
app.MapGet("/Leaderboard/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetLeaderboardById(id);
});


app.MapGet("/Leaderboard", ([FromServices] IDataRepository db) =>
{
    return db.GetLeaderboard();
}
);

//put function
app.MapPut("/Leaderboard/{id}", ([FromServices] IDataRepository db, Leaderboard Leaderboard) =>
{
    db.PutLeaderboard(Leaderboard);
});

//post function 
app.MapPost("/Leaderboard", ([FromServices] IDataRepository db, Leaderboard Leaderboard) =>
{
    db.AddLeaderboard(Leaderboard);
});

//Comments-----------------------------------------------------------------------

app.MapGet("/Comments/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetCommentsById(id);
});


app.MapGet("/Comments", ([FromServices] IDataRepository db) =>
{
    return db.GetComments();
}
);

//put function
app.MapPut("/Comments/{id}", ([FromServices] IDataRepository db, Comments Comments) =>
{
    db.PutComments(Comments);
});

//post function 
app.MapPost("/Comments", ([FromServices] IDataRepository db, Comments Comments) =>
{
    db.AddComments(Comments);
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
