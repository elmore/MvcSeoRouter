using System;
using System.Web;
using System.Web.Routing;

namespace MvcSeoRouter
{
    public class SeoRoute : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            throw new NotImplementedException();
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            throw new NotImplementedException();
        }
    }
}
