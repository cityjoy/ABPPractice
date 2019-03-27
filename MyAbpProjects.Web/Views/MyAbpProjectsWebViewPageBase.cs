using Abp.Web.Mvc.Views;

namespace MyAbpProjects.Web.Views
{
    public abstract class MyAbpProjectsWebViewPageBase : MyAbpProjectsWebViewPageBase<dynamic>
    {

    }

    public abstract class MyAbpProjectsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyAbpProjectsWebViewPageBase()
        {
            LocalizationSourceName = MyAbpProjectsConsts.LocalizationSourceName;
        }
    }
}