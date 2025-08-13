using Microsoft.Extensions.DependencyInjection;
namespace OnionGolmehr.API.Extensions;
public static class CorsExtensions
{
    /*
        Question :
        Why UseCors Isn’t in Your Extension Class ?
        Answer :
        AddCors(...) is used in the IServiceCollection to register the CORS policy.
        UseCors(...) is used in the IApplicationBuilder to apply the policy in the middleware pipeline.
        Since UseCors is already provided by ASP.NET Core, you don’t need to define it yourself.
    */
    public static IServiceCollection AddSecureCors(this IServiceCollection services)
    {
        /* 
            after development replace all localhost with static ip of your server machin or domain like:
            var allowedOrigins = new[]
            {
                "https://yourdomain.com",       // Covers all routes like /home, /admin, etc.
                "https://app.yourdomain.com",   // If you have a separate subdomain for frontend
                "https://localhost:7288",       // Dev frontend
                "http://localhost:5210"         // Dev frontend (HTTP)
            };
            and it doesn't need to add postfix of adress (only origin is enough
            origin is protocol(HTTp or HTTPS)+ "IP or Domain" + port number)
            and it not should be like https://localhost:7288/weather or https://yourdomain.com/admin
            only origin like:(https://localhost:7288 or https://yourdomain.com)
        */
        var allowedOrigins = new[]
        {
            "https://localhost:5000", // Blazor WebAssembly
            "https://localhost:7000", // MAUI Hybrid
            "https://localhost:7006", // API over HTTPS (maui will run as native so we don't know it's launchPort and url for know we will add 7000 on localhost , it is most common port for maui development)
            "http://localhost:5224",  // API over HTTP (temporary for development) , remove it(5224) after development because it is for http protocol and it is not secure
            "http://localhost:5210",  // Wasm(UI.Web) HTTP remove after development
            "https://localhost:7288"  // wasm(UI.web) HTTPS , keep it after develop
        };

        services.AddCors(options =>
        {
            options.AddPolicy("SecureCors", policy =>
            {
                policy.WithOrigins(allowedOrigins)
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowCredentials();
            });
        });
        return services;
    }
}

