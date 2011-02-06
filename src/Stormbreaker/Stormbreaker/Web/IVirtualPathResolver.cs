using System.Web.Routing;
using Stormbreaker.Models;

namespace Stormbreaker.Web {
    public interface IVirtualPathResolver {
        string ResolveVirtualPath(IPageModel pageModel, RouteValueDictionary routeValueDictionary);
    }
}