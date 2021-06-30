using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using Microsoft.Extensions.Logging;


namespace MentorsApi.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Languages.Any())
                {
                   var languageData = File.ReadAllText("../MentorsApi.Infrastructure/Data/seedData/languages.json");
                   var languages = JsonSerializer.Deserialize<List<Language>>(languageData);
                   foreach(var item in languages )
                   {
                       context.Languages.Add(item);
                   }
                   await context.SaveChangesAsync();
                }

                 if(!context.Expertises.Any())
                {
                   var expertisesData = File.ReadAllText("../MentorsApi.Infrastructure/Data/seedData/expertises.json");
                   var expertises = JsonSerializer.Deserialize<List<Expertise>>(expertisesData);
                   foreach(var item in expertises )
                   {
                       context.Expertises.Add(item);
                   }
                   await context.SaveChangesAsync();
                }
            }
            catch(Exception Ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(Ex.Message);
            }
        }
    }
}