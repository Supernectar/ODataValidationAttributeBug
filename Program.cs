using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<Customer>("Customers");

builder.Services
    .AddControllers()
    .AddOData(options => options
        .EnableQueryFeatures()
        .AddRouteComponents(
            modelBuilder.GetEdmModel()
        )
    );


var app = builder.Build();

app
    .UseRouting()
    .UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();