using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Exercice02.Helpers;

public static class BuilderExtensions
{
    public static void AddAuthentication(this WebApplicationBuilder builder)
    {
        var appSettingsSection = builder.Configuration.GetSection("AppSettings"); // récupérer la section
        var appSettings = appSettingsSection.Get<AppSettings>(); // la transformer en objet de type AppSettings
        var key = Encoding.ASCII.GetBytes(appSettings!.SecretKey); // récupérer la clé

        builder.Services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(x =>                                                    // on définit des critères de validation d'un token
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key), // on valide avec la clé
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
    }
}