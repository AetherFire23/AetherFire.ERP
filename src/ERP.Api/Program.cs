using AetherFire23.Commons.Composition;
using AetherFire23.ERP.Domain;
using ERP.Application.Installation;
using ERP.Infrastructure.Contexts;
using ERP.Scenarios.MoveToCommons;
using ERP.Seed;
using ERP.Seed.MoveToCommons;

namespace ERP.Api;

public partial class Program
{
    //TODO: put it inside config ?
    public static readonly string FRONTEND_URL = "http://localhost:5173";

    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddSwaggerGen();
        builder.Services.AddLogging();
        builder.Services.AddEndpointsApiExplorer();

        var composer = new Composer();

        composer.InstallServices(builder.Services, builder.Configuration,
            typeof(ApplicationInstaller).Assembly,
            typeof(DomainInstaller).Assembly,
            typeof(ErpContextInstaller).Assembly);

        builder.Services.AddControllers();

// Seed & scenario

        builder.Services.AddSeedServices(typeof(SeededCompany).Assembly);
        builder.Services.InstallScenarioLauncher();


        var app = builder.Build();

        composer.InitializeServices(app.Services);


        app.MapControllers();
        app.MapSwagger();
// Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI(a => { a.SwaggerEndpoint("/swagger/v1/swagger.json", "ERP API V1"); });
            app.Services.ExecuteSeedFromSeedName(args.ElementAt(args.IndexOf("--seed") + 1));
             app.Services.LaunchScenarioBrowser(args[args.IndexOf("--scenario") + 1]);
            // register scenario here 
        }

        app.UseCors(x => x.AllowAnyOrigin());

        app.UseHttpsRedirection();


        app.Run();
    }
}


// Seed :

// Map each seed method to a route via reflection 