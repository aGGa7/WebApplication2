using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Projects.Any() && !context.Objects.Any())
            {
                List<Project> projects = new List<Project>();
                List<ObjectOfProject> objects = new List<ObjectOfProject>();
                int i = 1;
                while (i<5)
                {
                     projects.Add(new Project { Name = "Project " + i, DateCreate = new DateTime(2021, 03, 16, 15, i, 00), Cipher = "Cipher " + i });
                   // context.Projects.Add(new Project { Name = "Project "+i, DateCreate = new DateTime(2021, 03, 16, 15, i, 00), Cipher = "Cipher "+i });
                    int j = 0;
                    while (j < 4)
                    {
                        objects.Add(new ObjectOfProject { Name = "Object " + i * j, Code = "Code " + i * j, Project = projects[i-1] });
                        // context.Objects.Add(new ObjectOfProject { Name = "Object "+i*j, Code = "Code "+i*j, Project = context.Projects.ToArray()[i-1] });
                        j++;
                    }
                    i++;
                    
                }
                context.Projects.AddRange(projects);
                context.Objects.AddRange(objects);
                context.SaveChanges();
            }
        }
    }
}
