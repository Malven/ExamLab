using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if ( context.Database == null )
                throw new Exception( "DB is null" );

            if ( context.Hobby.Any() )
                return;

            context.Hobby.AddRange(
                new Hobby() {
                    Title = "Gaming",
                    Description = "Gaming alot with my friends in different games."
                },
                new Hobby() {
                    Title = "Modelbuilding",
                    Description = "Building plastic models, everything from cars to tanks."
                },
                new Hobby() {
                    Title = "Movies/Series.",
                    Description = "Enjoy watching movies and series."
                });
            context.SaveChanges();
        }
    }
}
