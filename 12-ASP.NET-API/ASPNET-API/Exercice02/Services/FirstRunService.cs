﻿using Exercice02.Data;
using Exercice02.Helpers;
using Exercice02.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02.Services;

public class FirstRunService : IHostedService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly Encryptor _encryptor;

    public FirstRunService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
        _encryptor = new Encryptor(/*appSettings.Value.SecretKey!*/);
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var scope = _scopeFactory.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        // Applique les migrations automatiquement au démarrage
        await dbContext.Database.MigrateAsync(cancellationToken);

        // Vérifie s'il existe déjà un administrateur
        var user = await dbContext.Users.FirstOrDefaultAsync(u => u.IsAdmin, cancellationToken);
        if (user == null)
        {
            user = new User
            {
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@admin.com",
                IsAdmin = true,
                Password = _encryptor.EncryptPassword("P@ssWord!12"),
                PhoneNumber = "0123456789",
                Address = "adresse"
            };

            // Ajoute l'administrateur racine à la base de données
            await dbContext.Users.AddAsync(user, cancellationToken);
            if (await dbContext.SaveChangesAsync(cancellationToken) <= 0)
            {
                throw new Exception("Root Admin could not be created");
            }
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}