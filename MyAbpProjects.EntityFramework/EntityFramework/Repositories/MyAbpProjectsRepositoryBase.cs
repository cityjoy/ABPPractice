using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyAbpProjects.EntityFramework.Repositories
{
    public abstract class MyAbpProjectsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyAbpProjectsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyAbpProjectsRepositoryBase(IDbContextProvider<MyAbpProjectsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyAbpProjectsRepositoryBase<TEntity> : MyAbpProjectsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyAbpProjectsRepositoryBase(IDbContextProvider<MyAbpProjectsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
