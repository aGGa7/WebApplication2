using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EFRepository: IObjectsRepository
    {
        private ApplicationDbContext context;
        public EFRepository(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IQueryable<Project> Projects => context.Projects;
        public IQueryable<ObjectOfProject> Objects => context.Objects;
    }
}
