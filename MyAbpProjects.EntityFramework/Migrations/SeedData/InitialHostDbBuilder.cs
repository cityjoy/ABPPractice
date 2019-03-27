using MyAbpProjects.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyAbpProjects.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyAbpProjectsDbContext _context;

        public InitialHostDbBuilder(MyAbpProjectsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
