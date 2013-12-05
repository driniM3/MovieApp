using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieApp.Models.DB_Model;

namespace MovieApp.Controllers
{
    public class AuthorizeUsersAttribute : AuthorizeAttribute
    {
        // Custom property
        private bool _authorize = false;
        public string Access { get; set; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            
            if (base.AuthorizeCore(httpContext))
            {
                if (!string.IsNullOrEmpty(Access))
                {
                    string[] authorizedRoles = Access.Split(',').Select(x => x.Trim()).ToArray();
                    MovieAppDBContext _db = new MovieAppDBContext();

                    foreach (string role in authorizedRoles)
                    {

                        if (_db.AspNetUsers.Where(x => x.UserName == httpContext.User.Identity.Name).Single().AspNetRoles.Where(x=>x.Name == role).Any())
                        {
                            _authorize = true;
                        }
                    }
                }
                else
                {
                    _authorize = true;
                }
            }

            return _authorize;

        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller = "Account",
                                action = "Unauthorized"
                            })
                        );
        }
    }
}