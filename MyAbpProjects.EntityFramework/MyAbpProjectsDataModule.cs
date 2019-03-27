using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyAbpProjects.EntityFramework;

namespace MyAbpProjects
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyAbpProjectsCoreModule))]
    public class MyAbpProjectsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyAbpProjectsDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
