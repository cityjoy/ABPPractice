using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyAbpProjects.EntityFramework;

namespace MyAbpProjects.Migrator
{
    [DependsOn(typeof(MyAbpProjectsDataModule))]
    public class MyAbpProjectsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyAbpProjectsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}